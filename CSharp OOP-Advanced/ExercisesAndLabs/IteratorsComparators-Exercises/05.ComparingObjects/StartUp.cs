namespace _05.ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var set = new List<Person>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var tokens = command.Split();
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var town = tokens[2];
                var person = new Person(name, age, town);
                set.Add(person);
            }

            var n = int.Parse(Console.ReadLine());
            var item = set[n - 1];

            var numberOfEqualsMembers = set.Count(x => x.CompareTo(item) == 0);

            if (numberOfEqualsMembers < 2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numberOfEqualsMembers} {set.Count - numberOfEqualsMembers} {set.Count}");
            }
        }
    }
}