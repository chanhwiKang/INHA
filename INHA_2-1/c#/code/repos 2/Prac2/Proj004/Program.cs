using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Integer(1): ");
            int inputData1 = Console.Read();
            Console.WriteLine(inputData1);
            Console.ReadLine();

            Console.Write("Input Integer(2): ");
            string inputData2 = Console.ReadLine();
            Console.WriteLine(inputData2);

            Console.Write("P(1): ");
            string inputData3 = Console.ReadLine();
            Console.WriteLine(inputData3);

            Console.Write("P(2): ");
            string inputData4 = Console.ReadLine();
            Console.WriteLine(inputData4);

            string summary1 = inputData3 + inputData4;
            Console.WriteLine("Sum1: " + summary1);

            int summary2 = int.Parse(inputData3) + int.Parse(inputData4);
            Console.WriteLine("Sum2: " + summary2);
        }
    }
}
