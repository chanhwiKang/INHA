using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteVar = 10;
            int intVar = 10;
            double dblVar = intVar;
            Console.WriteLine(intVar);

            // intVar = dblVar;
            intVar = (int)dblVar;
            Console.WriteLine(intVar);

            bool boolVar = true;
            // intVar = (int)boolVar;

            char charVar = '1';
            intVar = charVar;
            Console.WriteLine(intVar);

            string strVar = "1";
            // intVar = strVar;

            intVar = int.Parse(strVar);
            strVar = intVar.ToString();
            Console.WriteLine(intVar);
            Console.WriteLine(strVar);
        }
    }
}
