using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj7
{
    internal class Employee
    {
        private string _name;
        public string Name { get; set; }
        private string _number;
        public string Number { get; set; }
        private string _depart;
        public string Depart { get; set; }
        private decimal _salary;
        public decimal Salary { get; set; }
        public Employee(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public decimal MonthlySalary
        {   get{
                return Salary / 12;
            }
        }

        public decimal ChangeSalary(double percent)
        {
            Salary *= (decimal)(percent*0.01 + 1.0);
            return Salary;
        }
    }
}
