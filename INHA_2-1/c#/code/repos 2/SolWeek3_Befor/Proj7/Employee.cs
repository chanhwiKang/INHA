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
            get {
                return Salary / 12;
            }
        }

        public void ChangeSalary(double percant) {

            Salary *= (decimal)((percant/100.0) + 1.0);
            
        }
    }
}