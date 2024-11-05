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
            Score score1 = new Score(10, 20, 30);
            Score score2 = new Score(10, 20, 30);

            Console.WriteLine(score1.Average);
            Console.WriteLine(score2.Average);
            //Console.WriteLine(score1.Average());
            //Console.WriteLine(score2.Average());
        }
    }
}
