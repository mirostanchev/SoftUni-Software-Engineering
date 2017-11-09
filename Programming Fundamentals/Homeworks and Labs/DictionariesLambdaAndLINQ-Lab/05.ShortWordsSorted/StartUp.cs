namespace _05.ShortWordsSorted
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var separators = new char[]{ '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            var input = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = input
                .OrderBy(x => x)
                .Distinct()
                .Where(x => x.Length < 5)
                .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}