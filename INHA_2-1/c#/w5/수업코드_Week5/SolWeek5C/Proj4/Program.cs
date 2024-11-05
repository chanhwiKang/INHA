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
            Member mem1 = new Member("김인하", 27, true);
            Member mem2 = new Member("이인하", 22);

            mem1.ChangeGrade();
            mem2.ChangeGrade();

            Console.WriteLine(mem1.Name);
            Console.WriteLine(mem1.Status);
            Console.WriteLine(mem2.Status);

        }
    }
}
