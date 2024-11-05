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
            //mem1.Name = "김인하";
            //mem1.Age = 27;
            //mem1.IsRegular = true;

            Member mem2 = new Member("이인하", 22);
            //mem2.Name = "이인하";
            //mem2.Age = 22;
            //mem2.IsRegular = false;

            // grade = grade == true ? false:true;
            mem1.ChangeGrade();
            mem2.ChangeGrade();

            Console.WriteLine(mem1.Name);
            Console.WriteLine(mem1.Status);
            Console.WriteLine(mem2.Status);

        }
    }
}
