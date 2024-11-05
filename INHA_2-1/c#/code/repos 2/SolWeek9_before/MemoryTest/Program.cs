using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueType va, vb;
            RefType ra, rb;

            va = new ValueType() { Name = "김인하", Age = 21 };
            vb = va;
            vb.Name = "이인하";
            Console.WriteLine(va.Name); //"김인하"

            ra = new RefType() { Name = "김인하", Age = 21 };
            rb = ra;
            rb.Name = "이인하";
            Console.WriteLine(ra.Name); //"이인하"

            ValueType[] valueTypes = new ValueType[] { va, vb };
            RefType[] types = new RefType[] { ra, rb };

            //va != vb != valuesTypes[0] != valuesTypes[1]
            va.Name = "김";
            vb.Name = "이";
            valueTypes[0].Name = "박";
            valueTypes[1].Name = "최";

            Console.WriteLine(va.Name);
            Console.WriteLine(vb.Name);
            Console.WriteLine(valueTypes[0].Name);
            Console.WriteLine(valueTypes[1].Name);


            Console.WriteLine("----------------------");
            //ra == rb == types[0] == types[1]
            ra.Name = "김";
            rb.Name = "이";
            types[0].Name = "박";
            types[1].Name = "최";

            Console.WriteLine(ra.Name);
            Console.WriteLine(rb.Name);
            Console.WriteLine(types[0].Name);
            Console.WriteLine(types[1].Name);
        }
    }
}
