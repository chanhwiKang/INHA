namespace Proj7
{
    class Employee
    {
        public string Name { get; private set; }
        public string Number { get; private set; }
        public string Depart { get; set; }
        public decimal Salary { get; set; }

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