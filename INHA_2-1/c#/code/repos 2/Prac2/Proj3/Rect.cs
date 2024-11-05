using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class Rect
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area {
            get {
                return Width * Height;
            }
        }
        public void ChangeWidth(double width)
        {
            Width = width;
        }
        public void ChangeHeight(double height)
        {
            Height = height;
        }
        public Rect() { }
        public Rect(double width, double height) {
            Width = width;
            Height = height;
        }
    }
}
