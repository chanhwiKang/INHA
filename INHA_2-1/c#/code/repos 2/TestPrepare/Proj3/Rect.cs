using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class Rect
    {
        private double _width;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0) _width = 1;
                else _width = value;
            }
        }
        private double _height;
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0) _height = 1;
                else _height = value;
            }
        }

        public double Area
        {
            get{
                return Width * Height;
            }
        }

        public void ChangeWidth(double changeValue)
        {
            if (Width + changeValue > 0)
                Width += changeValue;
            else return;
        }
        public void ChangeHeight(double changeValue)
        {
            if (Height + changeValue > 0)
                Height += changeValue;
            else return;
        }

        public Rect() { }
        public Rect(double width, double height)
        {
            if (width > 0)
                Width = width;
            else Width = 1;

            if (height > 0)
                Height = height;
            else Height = 1;
        }
    }
}
