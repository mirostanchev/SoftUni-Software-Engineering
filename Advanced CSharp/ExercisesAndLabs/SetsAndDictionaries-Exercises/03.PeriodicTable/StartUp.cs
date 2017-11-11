namespace _03.PeriodicTable
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    result.Add(elements[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}