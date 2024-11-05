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
            List<Rect> list = new List<Rect>();

            // Rect rect1 = new Rect(20.1, 30.5);
            list.Add(new Rect(20.1, 30.5));

            Rect rect2 = new Rect();
            rect2.Width = 2;
            rect2.Height = 3;
            list.Add(rect2);

            list[0].ChangeWidth(20.0);
            list[1].ChangeHeight(-3);

            Console.WriteLine(list[0].Width);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i].Area);
            // foreach (var rect in list)
            foreach (Rect rect in list) 
                Console.WriteLine(rect.Area);

        }
    }
}
