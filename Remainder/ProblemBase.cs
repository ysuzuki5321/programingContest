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
    public partial class ProblemBase : Form
    {
        protected Schedule schedule;
        protected List<Problem> Problems { get; set; }
        protected Problem Current { get; set; }
        protected int index = 0;

        public ProblemBase()
        {
            InitializeComponent();
        }

        public ProblemBase(Schedule schedule)
            : this()
        {
            this.schedule = schedule;
        }

        protected virtual bool Next()
        {
            bool result = true;
            if (Problems.Count == index)
            {
                Problems.Add(new Problem());
                result = false;
            }
            SetCurrent();
            return result;
        }

        protected virtual void SetCurrent()
        {
            Current = Problems[index];
            index++;
            ProblemText.Text = Current.ProblemText;
        }

        private void ProblemBase_Load(object sender, EventArgs e)
        {
            //　デザイナの場合はロードキャンセル
            if (DesignMode)
                return;

            Problems = GetProblems();
            SetupProblems();
            Next();
        }

        protected virtual void SetupProblems() { }
    }
}
