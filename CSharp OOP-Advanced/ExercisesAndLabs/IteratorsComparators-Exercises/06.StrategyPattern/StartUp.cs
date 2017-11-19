namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var firstSet = new SortedSet<Person>(new Person.NameComparator());
            var secondSet = new SortedSet<Person>(new Person.AgeComparator());

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var person = new Person(tokens[0], int.Parse(tokens[1]));

                firstSet.Add(person);
                secondSet.Add(person);
            }

            foreach (var item in firstSet)
            {
                Console.WriteLine(item);
            }

            foreach (var item in secondSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}