namespace _06.FoldAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var k = nums.Length / 4;

            var firstRowLeft = nums.Take(k).Reverse().ToArray();
            var firstRowRight = nums.Reverse().Take(k).ToArray();
            var firstRow = firstRowLeft.Concat(firstRowRight).ToArray();
            var secondRow = nums.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < firstRow.Length; i++)
            {
                secondRow[i] += firstRow[i];
            }

            Console.WriteLine(string.Join(" ", secondRow));
        }
    }
}