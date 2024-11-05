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
            List<Employee> list = new List<Employee>();
            // Employee emp1 = new Employee("김인하", "20240001");
            list.Add(new Employee("김인하", "20240001"));
            list[0].Depart = "경영지원";
            list[0].Salary = 3_600_0000;

            //Employee emp2 = new Employee("이인하", "20200005");
            list.Add(new Employee("이인하", "20200005"));
            list[1].Depart = "기술개발";
            list[1].Salary = 4_5000_000;

            list[0].ChangeSalary(5.6); //5.6% 상승

            foreach (var emp in list)
                Console.WriteLine($"{emp.Name}-{emp.Salary:F2}Won");
        }
    }
}
