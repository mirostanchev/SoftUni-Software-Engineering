namespace _07.EqualityLogic
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            Person q = obj as Person;
            return q != null && q.Name == this.Name && q.Age == this.Age;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            if (ReferenceEquals(null, other))
            {
                return 1;
            }

            var nameComparison = string.Compare(this.Name, other.Name, StringComparison.Ordinal);

            if (nameComparison != 0)
            {
                return nameComparison;
            }

            return this.Age.CompareTo(other.Age);
        }
    }
}