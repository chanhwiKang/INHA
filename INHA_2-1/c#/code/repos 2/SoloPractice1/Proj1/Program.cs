using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iVar;
            iVar = 1;

            const short sVAR = 1;

            double dVar = 1.1;
            char cVar = '1';
            bool bVar= true;
            string sVar = "1";

            Console.WriteLine("iVar:" + iVar);
            Console.WriteLine("int:" + sizeof(int));

            Console.WriteLine("dVar: " + dVar.ToString());
            Console.WriteLine("double: " + sizeof(double));

            Console.WriteLine("cVar:{0}, {1}", cVar, 111);
            Console.WriteLine("char:" + sizeof(char));

            Console.WriteLine($"bVar:{bVar}");
            Console.WriteLine($"bool:{sizeof(bool)}");

            Console.WriteLine("sVar" + sVar);
            Console.WriteLine("=========================");
            Console.WriteLine("dVar:" + dVar);
            Console.WriteLine("dVar:" + dVar.ToString());
            Console.WriteLine("dVar:" + dVar.ToString("F2"));
            Console.WriteLine("dVar:{0:F2}", dVar);
            Console.WriteLine($"dVar:{0:F2}", dVar);
            Console.WriteLine("double:" + sizeof(double));
            Console.WriteLine("=========================");
            Console.WriteLine("dVar:{0:F2}", dVar); 
            Console.WriteLine($"dVar:{dVar:F2}");
        }
    }
}
