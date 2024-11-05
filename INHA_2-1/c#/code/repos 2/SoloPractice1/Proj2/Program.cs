using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iVar1 = 100;
            int iVar2 = 200;

            iVar1 = 10000;
            iVar2 = iVar1;

            Console.WriteLine($"{iVar1},{iVar2}");

            byte bVar1 = 100;
            byte bVar2 = (byte)iVar2;
            byte bVar3 = (byte)1.1;
            Console.WriteLine($"{bVar1}, {bVar2}, {bVar3}");

            float fVar1 = 1.123456789123456789f;
            double fVar2 = 1.123456789123456789d;
            decimal fVar3 = 1.123456789123456789M;

            Console.WriteLine(fVar1);
            Console.WriteLine(fVar2);
            Console.WriteLine(fVar3);
        }
    }
}
