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
            List<Rect> rects = new List<Rect>();
            rects.Add(new Rect(20.1, 30.5));

            Rect rect2 = new Rect();
            rect2.Width = 2;
            rect2.Height = 3;
            rects.Add(rect2);

            rects[0].ChangeWidth(20.0);
            rects[1].ChangeHeight(-3);

#if false
            foreach(Rect rect in rects) {
                Console.WriteLine(rect.Area);
            }
#else
            for (int i = 0; i < rects.Count; i++) {
                Console.WriteLine(rects[i].Area);
            }
#endif

        }
    }
}
