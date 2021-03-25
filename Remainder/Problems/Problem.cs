using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder.Problems
{
    public class Problem
    {
        public int Id { get; set; } = -1;

        public int ScheduleId { get; set; }

        public string ProblemText { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();

        public bool HasWrong { get; set; }
    }
}
