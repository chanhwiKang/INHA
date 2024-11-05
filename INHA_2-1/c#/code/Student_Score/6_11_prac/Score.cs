using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_prac
{
    internal class Score
    {
        private string _subject;
        public string Subject { get { return _subject; } }
        public double Mid { get; set; }
        public double Final { get; set; }
        public double Attend { get; set; }
        public double Homework { get; set; }

        public Score(string subject)
        {
            _subject = subject;
        }
        public double Sum()
        {
            return Mid + Final + Attend + Homework;
        }
    }
}
