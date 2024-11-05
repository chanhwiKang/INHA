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
            ValueType va, vb; // struct
            RefType ra, rb; // class

            va = new ValueType() { Name = "kim", Age = 21 };
            vb = va;
            vb.Name = "Lee";
            Console.WriteLine(va.Name);

            ra = new RefType() { Name = "kim", Age = 21 };
            rb = ra;
            rb.Name = "Lee";
            Console.WriteLine(ra.Name);
        }
    }
    
}
