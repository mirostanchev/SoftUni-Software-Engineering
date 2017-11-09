namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var counter = new SortedDictionary<int, int>();

            foreach (var num in nums)
            {
                if (counter.ContainsKey(num))
                {
                    counter[num]++;
                }
                else
                {
                    counter[num] = 1;
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}