using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Score
    {
        /*public static double MidtermRate = 0.35;
        public static double FinalRate = 0.35;
        public static double AttendRate = 0.15;
        public static double HomeworkRate = 0.15;

        public double Midterm;
        public double Final;
        public double Attend;
        public double Homework;

        public double Sum()
        {
            var summary = Midterm + Final + Attend + Homework;
            return summary;
        }*/
        public int Kor { get; set; }
        public int Eng { get; set; }
        public int Mat { get; set; }

        public double Average
        {
            get
            {
                return (Kor + Eng + Mat) / 3;
            }
        }
        public Score(int kor, int eng, int mat)
        {
            Kor = kor;
            Eng = eng;
            Mat = mat;
        }
        public Score() { }
    }
}
