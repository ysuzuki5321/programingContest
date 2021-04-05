using Remainder.Problems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remainder
{
    public partial class CreateProblem : ProblemBase
    {
        public CreateProblem()
            : base()
        {
            InitializeComponent();
        }

        public CreateProblem(Schedule schedule)
            :base(schedule)
        {
            InitializeComponent();
        }

        private void AddAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AnswerText.Text))
                return;
            AnswerList.Items.Add(AnswerText.Text);
            AnswerText.Text = "";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var problem = ProblemText.Text;
            if (string.IsNullOrEmpty(problem))
            {
                MessageBox.Show("You must input problem text");
                return;
            }

            // delete insertとする
            // 問題削除
            if (Current.Id != -1)
            {
                Current.ProblemText = ProblemText.Text;
                UpdateProblem(Current);
                DeleteAnswers(Current.Id);
            }
            else
            {

                // 問題作成
                InsertProblem();
            }

            // 答え作成
            InsertAnswers();
            Next();
        }

        protected override bool Next()
        {
            var res = base.Next();

            AnswerList.Items.Clear();
            foreach(var item in Current.Answers)
            {
                AnswerList.Items.Add(item.AnswerText);
            }
            return res;
        }

        private void CreateProblem_Load(object sender, EventArgs e)
        {
            AnswerList.ContextMenuStrip = new ContextMenuStrip();
            AnswerList.ContextMenuStrip.Items.Add("Delete");
            AnswerList.ContextMenuStrip.Click += ContextMenuStripClicked;
        }

        private void ContextMenuStripClicked(object sender, EventArgs e)
        {
            AnswerList.Items.Remove(AnswerList.SelectedItem);
        }
    }


}
