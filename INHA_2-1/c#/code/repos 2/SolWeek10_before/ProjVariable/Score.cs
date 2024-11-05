using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjVariable
{
    class Score
    {
        public const double MidtermRate = 0.35;    //public static double MidtermRate = 0.35;
        public const double FinalRate = 0.35;    //public static double FinalRate = 0.35;
        public const double AttendRate = 0.15;    //public static double AttendRate = 0.15;
        public const double HomeworkRate = 0.15;    //public static double HomeworkRate = 0.15;

        public double Midterm;
        public double Final;
        public double Attend;
        public double Homework;
        
        public double Sum()
        {
            var summary = Midterm + Final + Attend + Homework;
            return summary;
        }
    }
}
