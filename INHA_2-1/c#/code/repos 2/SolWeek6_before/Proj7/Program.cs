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
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("김인하", "20240001"));
            employees[0].Depart = "경영지원";
            employees[0].Salary = 3_600_0000;

            Employee emp2 = new Employee("이인하", "20200005");
            emp2.Depart = "기술개발";
            emp2.Salary = 4_5000_000;
            employees.Add(emp2);

            employees[0].ChangeSalary(5.6); //5.6% 상승

#if false
            foreach(var emp in  employees) {
                Console.WriteLine($"{emp.Name} - {emp.Salary:F0}원");
            }
#else
            for (int i = 0; i < employees.Count; i++) {
                Console.WriteLine($"{employees[i].Name} - {employees[i].Salary:F1}원");
            }
#endif
        }
    }
}
