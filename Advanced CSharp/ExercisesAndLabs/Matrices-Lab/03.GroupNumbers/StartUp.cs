namespace _03.GroupNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var arr = new int[3][];
            var counters = new int[3];

            foreach (var num in nums)
            {
                if (Math.Abs(num) % 3 == 0)
                {
                    counters[0]++;
                }
                else if (Math.Abs(num) % 3 == 1)
                {
                    counters[1]++;
                }
                else if (Math.Abs(num) % 3 == 2)
                {
                    counters[2]++;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                arr[i] = new int[counters[i]];
            }

            var first = 0;
            var second = 0;
            var third = 0;

            foreach (var num in nums)
            {
                if (Math.Abs(num) % 3 == 0)
                {
                    arr[0][first] = num;
                    first++;
                }
                else if (Math.Abs(num) % 3 == 1)
                {
                    arr[1][second] = num;
                    second++;
                }
                else if (Math.Abs(num) % 3 == 2)
                {
                    arr[2][third] = num;
                    third++;
                }
            }

            for (int r = 0; r < arr.Length; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    Console.Write($"{arr[r][c]} ");
                }

                Console.WriteLine();
            }
        }
    }
}