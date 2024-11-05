using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1 + 2 + "3";
            var b = "1" + 2 + 3;
            Console.WriteLine($"{a} {b}");
        }
    }
}
