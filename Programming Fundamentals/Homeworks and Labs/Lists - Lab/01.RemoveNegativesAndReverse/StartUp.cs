namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            foreach (var num in numbers)
            {
                if (num >= 0)
                {
                    result.Add(num);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}