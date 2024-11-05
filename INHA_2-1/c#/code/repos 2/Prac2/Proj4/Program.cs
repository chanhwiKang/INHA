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
            Member member1 = new Member();
            member1.Name = "김인하";
            member1.Age = 27;
            member1.IsRegular = true;
            Member member2 = new Member();
            member2.Name = "이인하";
            member2.Age = 22;
            member2.IsRegular = false;
            Console.WriteLine(member1.Name);
            Console.WriteLine($"{member1.Name} is {(member1.IsRegular ? "aaa":"bbb")}");
            Console.WriteLine($"{member2.Name} is {(member2.IsRegular ? "aaa" : "bbb")}");
        }
    }
}
