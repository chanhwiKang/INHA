using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new FileStream("b.txt", FileMode.Create));
            sw.WriteLine(1234);
            sw.WriteLine(123.4);
            sw.WriteLine("Inha");
            sw.Close();

            StreamReader sr = new StreamReader(new FileStream("b.txt", FileMode.Open));
            while (false == sr.EndOfStream) {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
