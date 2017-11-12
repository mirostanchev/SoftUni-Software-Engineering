namespace _12.Google
{
    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company()
        {
        }

        public Company(string name, string department, decimal salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string Department { get => this.department; set => this.department = value; }
        public decimal Salary { get => this.salary; set => this.salary = value; }
    }
}