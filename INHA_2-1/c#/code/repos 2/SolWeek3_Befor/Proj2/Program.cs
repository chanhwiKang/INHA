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
            Score score1 = new Score();
            score1.Kor = 10;
            score1.Eng = 20;
            score1.Mat = 30;

            Score score2 = new Score();
            score2.Kor = 10;
            score2.Eng = 20;
            score2.Mat = 30;

            Console.WriteLine(score1.Average);
            Console.WriteLine(score2.Average);
        }
    }
}
