namespace _03.OldestFamilyMember
{
    public class Person
    {
        private string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }

    }
}