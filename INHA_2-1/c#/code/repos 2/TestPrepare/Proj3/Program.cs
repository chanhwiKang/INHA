using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rect rect1 = new Rect(20.1, 30.5);

            Rect rect2 = new Rect();
            rect2.Width = 2;
            rect2.Height = 3;

            Console.WriteLine(rect1.Width);
            Console.WriteLine(rect1.Area);
            Console.WriteLine(rect2.Area);
        }
    }
}
