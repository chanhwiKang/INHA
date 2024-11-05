using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iVar;
            iVar = 1;
            const short sVar = 1;
            double dVar = 1.1;
            char cVar = '1';
            bool bVar = true;
            string strVar = "1";

            Console.WriteLine("iVar: " + iVar);
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("========================");
            Console.WriteLine("dVar: " + dVar.ToString());
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("========================");
            Console.WriteLine("cVar: {0}", cVar);
            Console.WriteLine("char: " + sizeof(char));
            Console.WriteLine("========================");
            Console.WriteLine($"bVar: {bVar}");
            Console.WriteLine($"bool: {sizeof(bool)}");
            Console.WriteLine("========================");
            Console.WriteLine("strVar: " + strVar);
            // Console.WriteLine($"string: {sizeof(string)}");
            Console.WriteLine("========================");
            Console.WriteLine("========================");
            Console.WriteLine("dVar: " + dVar);
            Console.WriteLine("dVar: " + dVar.ToString());
            Console.WriteLine("dVar: " + dVar.ToString("F2"));
            Console.WriteLine("dVar: {0:F2}", dVar);
            Console.WriteLine($"dVar: {dVar:F2}");
            Console.WriteLine("double: " + sizeof(double));
        }
    }
}
