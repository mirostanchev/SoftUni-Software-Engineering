namespace _01.CountRealNumbers
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
                .Select(double.Parse)
                .ToList();

            var numberCount = new SortedDictionary<double, int>();

            foreach (var num in nums)
            {
                if (!numberCount.ContainsKey(num))
                {
                    numberCount[num] = 0;
                }

                numberCount[num]++;
            }

            foreach (var item in numberCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}