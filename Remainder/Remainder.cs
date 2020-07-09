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

namespace Remainder
{
    public partial class Remainder : Form
    {
        private DbContext DbContext = new DbContext(ConfigurationManager.ConnectionStrings["MyDbContext"].ConnectionString);
        public Remainder()
        {
            InitializeComponent();
        }

        private void Remainder_Load(object sender, EventArgs e)
        {
            var interval = Interval();
            var sql = DataSql();
            var param = new DynamicParameters();
            param.AddDynamicParams(new { interval = interval });

            var data = DbContext.Database.Connection.Query<Schedule>(sql,param);
            TodayGrid.DataSource = data;
            
            if (data == null) { }
        }

        private string DataSql()
        {
            return @"
                select
                    *    
                from
                    Schedule
                where
                    (((@interval - start) / interval) * interval + start) =@interval
                order by
                    interval,priority,id
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
            var data = DbContext.Database.Connection.QueryFirstOrDefault<DateTime>(sql);
            return DateTime.Now.Subtract(data).Days;
        }

        private void TodayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TodayGrid.Columns[e.ColumnIndex].Name == nameof(Schedule.Url))
            {
                System.Diagnostics.Process.Start(TodayGrid.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex].Value as string);
            }
        }
    }
}
