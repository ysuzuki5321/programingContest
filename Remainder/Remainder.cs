using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Remainder
{
    public partial class Remainder : Form
    {
        private BindingList<Schedule> Data;
        public Remainder()
        {
            InitializeComponent();
        }
        int offsetWidth = 40;
        int offsetHeight = 120;
        int interval;
        private void Remainder_Load(object sender, EventArgs e)
        {
            DataBase.Connection.Open();
            Width = 1000;
            TodayGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            interval = Interval();

            SetUpColumn();
            TodayGrid.Columns[nameof(Schedule.Discription)].ReadOnly = false;
            TodayGrid.Columns["Expand"].DefaultCellStyle.BackColor = Color.Red;
            TodayGrid.Columns["Update"].DefaultCellStyle.BackColor = Color.Brown;
            TodayGrid.Columns["AddProblem"].DefaultCellStyle.ForeColor = Color.Red;
            Data = new BindingList<Schedule>();
            Data.AllowNew = false;
            ShowData();
            SetGridSize();
        }

        private void ShowData()
        {
            var sql = DataSql();
            var param = new DynamicParameters();
            param.AddDynamicParams(new { interval = interval });
            Data.Clear();
            DataBase.Connection.Query<Schedule>(sql, param).ToList().ForEach(x => Data.Add(x));
            TodayGrid.DataSource = Data;
            TodayGrid.Columns["ProblemCount"].Visible = false;
            for (int i = 0; i < TodayGrid.Rows.Count; i++)
            {
                if(Data[i].ProblemCount > 0)
                {
                    TodayGrid.Rows[i].Cells["Exam"].Style.BackColor = Color.Blue;
                }
            }

        }

        private void SetUpColumn()
        {
            AddCol<DataGridViewTextBoxColumn>("Id",30);
            AddCol<DataGridViewTextBoxColumn>("Discription",300);
            AddCol<DataGridViewLinkColumn>("Url",100);
            AddCol<DataGridViewTextBoxColumn>("Interval",50);
            AddCol<DataGridViewTextBoxColumn>("Start",50);
            AddCol<DataGridViewButtonColumn>("Done",30);
            AddCol<DataGridViewButtonColumn>("Expand",50);
            AddCol<DataGridViewButtonColumn>("NextWeek", 40);
            AddCol<DataGridViewButtonColumn>("Tommorow", 40);
            AddCol<DataGridViewButtonColumn>("Update", 40);
            AddCol<DataGridViewButtonColumn>("AddProblem", 30);
            AddCol<DataGridViewButtonColumn>("Exam", 30);
        }

        private void AddCol<T>(string data,int width = -1) where T : DataGridViewColumn, new()
        {
            var col = CreateColumns<T>(data);
            if(width != -1)
            {
                col.Width = width;
            }
            TodayGrid.Columns.Add(col);
        }

        private T CreateColumns<T>(string data) where T :DataGridViewColumn,new() 
        {
            return new T(){ ReadOnly=true,DataPropertyName=data,Name=data };
        }

        private string DataSql()
        {
            return @"
                select
                    *    
                    ,(select count(*) from problem p where
                    p.scheduleid = s.id) ProblemCount
                from
                    Schedule s
                where
                    (((@interval - s.start) / s.interval) * s.interval + s.start) =@interval
                    and (
                        s.latestDate is null
                        or s.latestDate < CONVERT(DATE, getdate())
                    )
                order by
                    s.interval,s.priority,s.id
                ";
        }

        private int Interval()
        {
            var sql = @"
                select
                    Date
                from
                    Criteron
                ";
            // 当日と開始日の日数
            var data = DataBase.Connection.QueryFirstOrDefault<DateTime>(sql);
            return DateTime.Now.Subtract(data).Days;
        }

        private void TodayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TodayGrid.Columns[e.ColumnIndex].Name == nameof(Schedule.Url))
            {
                System.Diagnostics.Process.Start(TodayGrid.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex].Value as string);
            }

            if (TodayGrid.Columns[e.ColumnIndex].Name == "Done")
            {
                RemoveAt(e.RowIndex);
            }

            if (TodayGrid.Columns[e.ColumnIndex].Name == "Expand")
            {
                ExpandData(e.RowIndex);
            }

            if (TodayGrid.Columns[e.ColumnIndex].Name == "NextWeek")
            {
                NextWeek(e.RowIndex);
            }

            if (TodayGrid.Columns[e.ColumnIndex].Name == "Tommorow")
            {
                Tommorow(e.RowIndex);
            }

            if (TodayGrid.Columns[e.ColumnIndex].Name == "Update")
            {
                var data = TodayGrid.Rows[e.RowIndex].DataBoundItem as Schedule;
                if (!string.IsNullOrWhiteSpace(UrlText.Text))
                {
                    data.Url = UrlText.Text;
                    UrlText.Text = "";
                }
                UpdateSchedule(data);
                ShowData();
            }

            if (TodayGrid.Columns[e.ColumnIndex].Name == "AddProblem")
            {
                ToCreateProblem(TodayGrid.Rows[e.RowIndex].DataBoundItem as Schedule);
            }

            if (TodayGrid.Columns[e.ColumnIndex].Name == "Exam")
            {
                if(!ToExam(TodayGrid.Rows[e.RowIndex].DataBoundItem as Schedule))
                {
                    TodayGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void ToCreateProblem(Schedule schedule)
        {
            var createForm = new CreateProblem(schedule);
            createForm.ShowDialog();
        }

        private bool ToExam(Schedule schedule)
        {
            var exam = new Exam(schedule);
            var result = exam.ShowDialog();
            if (result == DialogResult.No)
            {
                return false;
            }else
            {
                return true;
            }
        }

        private void Remainder_SizeChanged(object sender, EventArgs e)
        {
            SetGridSize();
        }

        private void SetGridSize()
        {
            TodayGrid.Size = new Size(Size.Width - offsetWidth, Size.Height - offsetHeight);

        }

        private void RemoveAt(int i)
        {
            DoneSchedule(TodayGrid.Rows[i].DataBoundItem as Schedule);
            TodayGrid.Rows.RemoveAt(i);
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace( NoteText.Text) 
                && string.IsNullOrWhiteSpace(UrlText.Text))
            {
                MessageBox.Show("Must input note or url.");
                return;
            }

            var start = interval % 7;
            var param = new DynamicParameters(new
            {
                discription = NoteText.Text,
                url = UrlText.Text,
                interval = 7,
                start = start,
                priority = 0
            });
            DataBase.Connection.Execute(InsertSql(), param);
            NoteText.Text = "";
            UrlText.Text = "";
            ShowData();
        }
    }
}
