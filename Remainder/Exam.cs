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
    public partial class Exam : ProblemBase
    {
        bool Confirmed { get; set; }
        bool HasWrong { get; set; }
        public Exam()
            : base()
        {
            InitializeComponent();
        }

        public Exam(Schedule schedule)
            : base(schedule)
        {
            InitializeComponent();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            ProblemText.ReadOnly = true;
        }

        protected override void SetupProblems()
        {
            // 全ての問題が間違いありの状態にする
            remain = Enumerable.Range(0, Problems.Count).ToList();
            Problems.ForEach(x => x.HasWrong = true);
        }

        private List<(TextBox,Label)> answerList = new List<(TextBox, Label)>();
        private List<int> remain = new List<int>();

        private int GetNextIndex()
        {
            for (; index < Problems.Count; index++)
            {
                if (Problems[index].HasWrong)
                {
                    return index;
                }
            }
            return -1;
        }

        protected override bool Next()
        {

            // 間違えていたら間違えている問題をもう一度
            index = GetNextIndex();
            if (index < 0)
            {
                if (HasWrong)
                {
                    HasWrong = false;
                    index = 0;
                    index = GetNextIndex();
                    SetCurrent();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                SetCurrent();
            }

            // パネルにテキストボックスを等間隔で縦に置いていく
            int i = 0;
            answerList.Clear();
            AnswersPanel.Controls.Clear();
            foreach (var item in Current.Answers)
            {
                SetTextBox(i++);
            }

            return false;
        }

        private void SetTextBox(int answerIndex)
        {
            var font = new Font("MSゴシック", 12f);
            const int interval = 30;
            var y = interval * (answerIndex + 1);
            var label = new Label();
            label.Text = $"({answerIndex + 1})";
            label.Font = new Font(font, FontStyle.Regular);
            label.Location = new Point(10, y);
            label.Width = 30;
            var text = new TextBox();
            text.Width = 200;
            text.Font = new Font(font,FontStyle.Regular); 
            text.Location = new Point(label.Right + 5,y);
            text.AutoCompleteMode = AutoCompleteMode.Suggest;
            var answerLabel = new Label();
            answerLabel.AutoSize = true;
            answerLabel.Font = new Font(font, FontStyle.Regular);
            answerLabel.Location = new Point(text.Right + 5, y);
            AnswersPanel.Controls.Add(label);
            AnswersPanel.Controls.Add(text);
            AnswersPanel.Controls.Add(answerLabel);
            answerList.Add((text,answerLabel));
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            // 確認終わってるときは次の問題へ
            if (Confirmed)
            {
                Next();
                Confirmed = false;
                Confirm.Text = "確認";
                return;
            }

            Confirmed = true;
            Current.HasWrong = false;
            for (int i = 0; i < Current.Answers.Count; i++)
            {
                var actual = answerList[i].Item1.Text;
                var expected = Current.Answers[i].AnswerText;
                if (actual == expected)
                {
                    answerList[i].Item2.Text = "○";
                    answerList[i].Item2.ForeColor = Color.Blue;
                }
                else
                {
                    HasWrong = true;
                    Current.HasWrong = true;
                    answerList[i].Item2.Text = expected;
                    answerList[i].Item2.ForeColor = Color.Red;
                }
            }

            Confirm.Text = "次へ";
        }


    }
}
