using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj7
{
    internal class Employee
    {
        public string Name;
        public string Number;
        public string Depart;
        public decimal Salary;

        public decimal MonthlySalary
        {
            get
            {
                var result = Salary / 12;
                return result;
            }
        }
    }
}
