using System;

namespace Proj3
{
    internal class Rect
    {
        public double Width;
        public double Height;

        public double Area
        {
            get {
                return Width * Height;
            }
        }

        public double GetArea() //getter
        {
            return Width * Height;
        }

        public bool ChangeWidth(double size)
        {
            if(size + Width < 0) {
                return false;
            }

            Width += size;
            return true;
        }

        public bool ChangeHeight(double size)
        {
            if (size + Height < 0)
            {
                return false;
            }

            Height += size;
            return true;
        }

    }
}