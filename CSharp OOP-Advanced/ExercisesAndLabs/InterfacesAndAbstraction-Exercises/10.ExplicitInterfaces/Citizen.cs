namespace _10.ExplicitInterfaces
{
    public class Citizen : IPerson,IResident
    {
        private string name;

        public Citizen(string name, string country, int age)
        {
            this.name = name;
            this.Country = country;
            this.Age = age;
        }

        string IPerson.Name
        {
            get { return this.name; }
        }

        public string Country { get; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.name}";
        }

        public int Age { get; }

        string IResident.Name
        {
            get { return this.name; }
        }

        string IPerson.GetName()
        {
            return this.name;
        }
    }
}