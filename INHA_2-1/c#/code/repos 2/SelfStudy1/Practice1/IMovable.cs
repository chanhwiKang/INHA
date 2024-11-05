using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal interface IMovable
    {
        bool Left(double move);
        bool Right(double move);
        bool Forward(double move);
        bool Backward(double move);
    }
}
