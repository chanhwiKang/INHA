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
            Dictionary<string, Score> sc = new Dictionary<string, Score>();
            int cnt = 0;
            while (cnt < 3)
            {
                Console.Write("Number : ");
                string number = Console.ReadLine();
                if (string.IsNullOrEmpty(number) || number.Length < 5)
                    continue;
                if (sc.ContainsKey(number))
                    continue;

                Console.Write("Kor : ");
                if (!int.TryParse(Console.ReadLine(), out int kor))
                    continue;

                Console.Write("Eng : ");
                if (!int.TryParse(Console.ReadLine(), out int eng))
                    continue;

                Console.Write("Mat : ");
                if (!int.TryParse(Console.ReadLine(), out int mat))
                    continue;

                sc[number] = new Score(kor, mat, eng);
                cnt++;
            }
            foreach(var key in sc.Keys)
            {
                Console.WriteLine($"Number : {key}");
                Console.WriteLine($"Avg : {sc[key].Average}");
            }
            foreach (var dict in sc)
                Console.WriteLine(dict);
        }
    }
}
