namespace _02.SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var info = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var n = info[0];
            var m = info[1];

            var first = new HashSet<int>();
            var second = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var value = int.Parse(Console.ReadLine());
                first.Add(value);
            }

            for (int i = 0; i < m; i++)
            {
                var value = int.Parse(Console.ReadLine());
                second.Add(value);
            }

            var nums = new HashSet<int>();

            foreach (var item in first)
            {
                if (second.Contains(item))
                {
                    nums.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}