namespace _05.RoundingNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0} => {1}", nums[i], Math.Round(nums[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}