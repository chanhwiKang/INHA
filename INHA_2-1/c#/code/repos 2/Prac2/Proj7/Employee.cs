using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj7
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Depart { get; set; }
        public decimal Salary { get; set; }
        public Employee() { }
        public Employee(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
