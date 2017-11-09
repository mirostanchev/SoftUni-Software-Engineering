namespace _05.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            numbers = RemoveBombedNumbers(numbers);
            Console.WriteLine(numbers.Sum());
        }

        public static List<long> RemoveBombedNumbers(List<long> numbers)
        {
            var bombData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var bombNumber = bombData[0];
            var bombRange = bombData[1];

            while (numbers.IndexOf(bombNumber) != -1)
            {
                var bombIndex = numbers.IndexOf(bombNumber);
                var bombRangeStart = Math.Max(bombIndex - bombRange, 0);
                var bombRangeEnd = Math.Min(bombIndex + bombRange, numbers.Count - 1);

                numbers.RemoveRange(bombRangeStart, bombRangeEnd - bombRangeStart + 1);
            }

            return numbers;
        }
    }
}