namespace _04.LargestThreeNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var result = list
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}