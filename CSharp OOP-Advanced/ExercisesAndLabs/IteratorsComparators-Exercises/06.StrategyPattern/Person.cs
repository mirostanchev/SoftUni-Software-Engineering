namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
    
        public int Age { get; set; }

        public class AgeComparator : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }

        public class NameComparator : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int result = x.Name.Length.CompareTo(y.Name.Length);

                if (result == 0)
                {
                    result = x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
                }

                return result;
            }
        }

        public int CompareTo(Person other)
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}