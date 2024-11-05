using System;

namespace Proj3
{
    class Rect
    {
        private double _width;
        public double Width
        {
            get { return _width; }
            set { 
                if (value > 0) _width = value;
                else _height = 1.0;
            }
        }
        private double _height;
        public double Height
        {
            get { return _height; }
            set { 
                if (value > 0) _height = value;
                else _height = 1.0;
            }
        }

        
        public double Area
        {
            get {
                return _width * _height;
            }
        }

        public bool ChangeWidth(double size)
        {
            if (_width + size < 0) {
                return false;
            }

            _width += size;
            return true;
        }

        public bool ChangeHeight(double size)
        {
            if (_height + size < 0) {
                return false;
            }
            _height += size;
            return true;
        }

        public Rect() { }

        public Rect(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}