using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var rate1 = $"중간:{Score.MidtermRate * 100}%";
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
            Console.WriteLine(score2.Sum());*/
            Dictionary<string, Score> scores = new Dictionary<string, Score>();
            int count = 0;
            while (count < 3)
            {
                Console.Write("Student Number: ");
                var number = Console.ReadLine();
                if (string.IsNullOrEmpty(number) || number.Length < 5){
                    continue;
                }
                if (scores.ContainsKey(number)) { continue; }
                Console.Write("Kor: ");
                if(false == int.TryParse(Console.ReadLine(), out int Kor)){ continue; }
                Console.Write("Eng: ");
                if(false == int.TryParse(Console.ReadLine(), out int Eng)) { continue; }
                Console.Write("Mat: ");
                if(false == int.TryParse(Console.ReadLine(), out int Mat)) { continue; }
                scores[number] = new Score(Kor, Eng, Mat);
                count++;
            }
            foreach(var data in scores)
            {
                Console.WriteLine($"Stu_num: {data.Key}, Kor: {data.Value.Kor}");
            }
            /*Score score1 = new Score();
            score1.Kor = 10;
            score1.Eng = 20;
            score1.Mat = 30;
            Score score2 = new Score();
            score2.Kor = 30;
            score2.Eng = 40;
            score2.Mat = 50;

            Console.WriteLine(score1.Kor);
            Console.WriteLine(score1.Average);
            Console.WriteLine(score2.Average);*/
        }
    }
}
