using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInterface
{
    interface IPrintable
    {
        void Print(string data);
    }
    class SoftData : IPrintable
    {
        public void Print(string data)
        {
            Console.WriteLine(data);
        }
    }
    class HardData : IPrintable
    {
        public void Print(string data)
        {
            using (var file = File.CreateText("a.txt"))
            {
                file.WriteLine(data);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] printables = new IPrintable[2];
            printables[0] = new SoftData();
            printables[1] = new HardData();
            for (int i = 0; i < printables.Length; i++)
            {
                var data = ((i + 1) * 1000).ToString();
                printables[i].Print(data);
            }

        }
    }
}
