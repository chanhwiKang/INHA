using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class Rect
    {
        public double Width;
        public double Height;

        public double Area
        {
            get
            {
                var result = Width * Height;
                return result;
            }
        } 
    }
}
