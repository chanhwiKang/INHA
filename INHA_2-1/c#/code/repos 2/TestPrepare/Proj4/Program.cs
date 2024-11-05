using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member("Kim", 27, true);
            Member member2 = new Member("Lee", 22);

            Console.WriteLine(member1.Name);
            Console.WriteLine(member2.Status);
        }
    }
}
