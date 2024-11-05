using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int number = int.Parse(Console.Read());
            int number;
            string input = Console.ReadLine();
            bool reuslt = int.TryParse(input, out number);
        }
    }
}
