using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using practice
            using (BinaryWriter bw = new BinaryWriter(new FileStream("b.dat", FileMode.Create))) {
                bw.Write(1234);
                bw.Write(123.4);
                bw.Write("Inha");
            };

            BinaryReader br = new BinaryReader(new FileStream("b.dat", FileMode.Open));
            int a = br.ReadInt32();
            double b = br.ReadDouble();
            string c = br.ReadString();
            br.Close();

            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}
