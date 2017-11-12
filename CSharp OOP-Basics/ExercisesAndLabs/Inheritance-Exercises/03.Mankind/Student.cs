namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            set
            {
                if (value.Length < 5 || value.Length > 10 || !IsValidFacultyNumber(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        private bool IsValidFacultyNumber(string value)
        {
            var isValidFacultyNumber = true;

            foreach (char ch in value)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    isValidFacultyNumber = false;
                }
            }

            return isValidFacultyNumber;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("First Name: ").AppendLine(base.FirstName)
                .Append("Last Name: ").AppendLine(base.LastName)
                .Append("Faculty number: ").AppendLine(this.facultyNumber);

            return sb.ToString();
        }
    }
}