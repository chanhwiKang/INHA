using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "김인하";
            emp1.Number = "20240001";
            emp1.Depart = "경영지원";
            emp1.Salary = 3_600_0000;

            Employee emp2 = new Employee();
            emp2.Name = "이인하";
            emp2.Number = "20200005";
            emp2.Depart = "기술개발";
            emp2.Salary = 4_5000_000;

            emp1.ChangeSalary(5.6); // 5.6% Up

            Console.WriteLine($"월급:{emp1.MonthlySalary}");
        }
    }
}
