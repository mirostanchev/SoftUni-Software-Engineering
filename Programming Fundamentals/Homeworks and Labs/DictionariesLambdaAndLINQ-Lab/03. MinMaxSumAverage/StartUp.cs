namespace _03.MinMaxSumAverage
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("Average = {0}", nums.Average());
        }
    }
}