namespace _05.SortNumbers
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
                .Select(decimal.Parse)
                .ToList();

            var sorted = nums.OrderBy(a => a);

            Console.WriteLine(string.Join(" <= ", sorted));
        }
    }
}