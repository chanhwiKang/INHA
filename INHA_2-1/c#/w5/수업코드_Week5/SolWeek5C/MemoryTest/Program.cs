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
            Console.WriteLine(va.Name);

            ra = new RefType() { Name = "박인하", Age = 21 };
            rb = ra;
            rb.Name = "최인하";
            Console.WriteLine(ra.Name);
        }
    }
}
