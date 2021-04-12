using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Discription { get; set; }
        public string Url { get; set; }
        public int Interval { get; set; }
        public int Start { get; set; }

        public DateTime? LatestDate { get; set; }

        public int ProblemCount { get; set; }
    }
}
