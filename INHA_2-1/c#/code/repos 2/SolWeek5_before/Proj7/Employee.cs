namespace Proj7
{
    class Employee
    {
        public string Name;
        public string Number;
        public string Depart;
        public decimal Salary;

        public decimal MonthlySalary
        {
            get {
                return Salary / 12;
            }
        }

        public decimal ChangeSalary(double percent)
        {
            Salary *= (decimal)(1.0 + (percent / 100.0));
            return Salary;
        }

        public Employee(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}