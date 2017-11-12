namespace _04.OpinionPoll
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                var lineArgs = line.Split();
                var name = lineArgs[0];
                var age = int.Parse(lineArgs[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            var result = family.FilterAndSort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}