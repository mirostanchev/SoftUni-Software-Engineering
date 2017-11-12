namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal GetMoneyPerHour()
        {
            return (this.weekSalary / 5) / this.workHoursPerDay;
        }

        public override string LastName
        {
            get { return base.LastName; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                base.LastName = value;
            }
        }

        public decimal WeekSalary
        {
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("First Name: ").AppendLine(base.FirstName)
                .Append("Last Name: ").AppendLine(base.LastName)
                .Append("Week Salary: ").AppendLine($"{this.weekSalary:f2}")
                .Append("Hours per day: ").AppendLine($"{this.workHoursPerDay:f2}")
                .Append("Salary per hour: ").Append($"{this.GetMoneyPerHour():f2}");

            return sb.ToString();
        }
    }
}