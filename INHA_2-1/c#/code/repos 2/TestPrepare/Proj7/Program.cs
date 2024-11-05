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
            Employee emp1 = new Employee("김인하", "20240001");
            emp1.Depart = "경영지원";
            emp1.Salary = 3_600_0000;
            Employee emp2 = new Employee("이인하", "20200005");
            emp2.Depart = "기술개발";
            emp2.Salary = 4_5000_000;

            Console.WriteLine($"월급:{emp1.MonthlySalary}");
            Console.WriteLine($"Salary: {emp1.Salary}");
            emp1.ChangeSalary(5);
            Console.WriteLine($"Salary: {emp1.Salary}");
        }
    }
}
