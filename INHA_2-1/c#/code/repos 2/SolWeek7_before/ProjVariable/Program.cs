using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var rate1 = $"중간:{Score.MidtermRate * 100}%";
            var rate2 = $"기말:{Score.FinalRate * 100}%";
            var rate3 = $"출석:{Score.AttendRate * 100}%";
            var rate4 = $"과제:{Score.HomeworkRate * 100}%";

            Console.WriteLine(rate1);
            Console.WriteLine(rate2);
            Console.WriteLine(rate3);
            Console.WriteLine(rate4);

            Score score1 = new Score();
            Score score2 = new Score();

            score1.Midterm = 100;
            score1.Final = 90;
            score1.Attend = 90;
            score1.Homework = 100;
            Console.WriteLine(score1.Sum());

            score2.Midterm = 90;
            score2.Final = 80;
            score2.Attend = 80;
            score2.Homework = 100;
            Console.WriteLine(score2.Sum());
        }
    }
}
