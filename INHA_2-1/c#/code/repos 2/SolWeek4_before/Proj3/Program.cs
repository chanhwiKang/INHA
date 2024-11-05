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
            Rect rect1 = new Rect(20.1, 30.5); // Rect.cs 14Line (method overload)
            //rect1.Width = 20.1;
            //rect1.Height = 30.5;

            Rect rect2 = new Rect(); // Rect.cs 11Line (method overload)
            rect2.Width = 2;
            rect2.Height = 3;

            rect1.ChangeWidth(20.0);
            rect1.ChangeHeight(-3);

            Console.WriteLine(rect1.Width);
            Console.WriteLine(rect1.Area);
            Console.WriteLine(rect2.Area);

        }
    }
}
