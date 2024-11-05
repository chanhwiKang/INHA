using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Car : Product, IMovable
    {
        private double _forBackMove;
        private double _leftRightMove;
        public double ForBackMove { get { return _forBackMove; } set { _forBackMove = value; } }
        public double LeftRightMove { get { return _leftRightMove; } set { _leftRightMove = value; } }
        public Car(string name, int price) : base(name, price)
        {
        }

        public Car(string name, int price, int quantity) : base(name, price, quantity)
        {
        }

        public bool Backward(double move)
        {
            if (ForBackMove - move <= -100_000){
                Console.WriteLine("100Km Over");
                return false;
            } else {
                Console.WriteLine("Move to Forward, " + move);
                ForBackMove -= move;
                Console.WriteLine("Current For/Back move is, " + ForBackMove);
                return true;
            }

        }

        public bool Forward(double move)
        {
            if (ForBackMove + move >= 100_000)
            {
                Console.WriteLine("100Km Over");
                return false;
            }
            else
            {
                Console.WriteLine("Move to Forkward, " + move);
                ForBackMove += move;
                Console.WriteLine("Current For/Back move is, " + ForBackMove);
                return true;
            }
        }

        public bool Left(double move)
        {
            if (LeftRightMove - move <= -100_000)
            {
                Console.WriteLine("100Km Over");
                return false;
            }
            else
            {
                Console.WriteLine("Move to Left, " + move);
                LeftRightMove -= move;
                Console.WriteLine("Current Left/Right move is, " + LeftRightMove);
                return true;
            }
        }

        public bool Right(double move)
        {
            if (LeftRightMove + move >= 100_000)
            {
                Console.WriteLine("100Km Over");
                return false;
            }
            else
            {
                Console.WriteLine("Move to Right, " + move);
                LeftRightMove += move;
                Console.WriteLine("Current Left/Right move is, " + LeftRightMove);
                return true;
            }
        }
    }
}
