using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Product1 pro1 = new Product1("kim", 1000, 10);
            //            Product2 pro2 = new Product2("kim", 1000, 10);
            //            Product3 pro3 = new Product3("kim", 1000, 10);

            //            Console.WriteLine($"Product1: {pro1.ToString()}");
            //            Console.WriteLine($"Product2: {pro2.ToString()}");
            //            Console.WriteLine($"Product3: {pro3.ToString()}");

            Car car1 = new Car("Mustang", 30_000_000, 2);
            Console.WriteLine($"{car1.ToString()}");
            car1.Left(1000.0);
            car1.Right(500);
            car1.Forward(3500.7);
            car1.Backward(700);
        }
    }
}
