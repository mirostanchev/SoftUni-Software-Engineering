namespace _03.FoldAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var k = numbers.Length / 4;

            var firstRowLeft = numbers.Take(k).Reverse().ToArray();
            var firstRowRight = numbers.Reverse().Take(k).ToArray();
            var secondRow = numbers.Skip(k).Take(2 * k).ToArray();
            var firstRow = firstRowLeft.Concat(firstRowRight).ToArray();

            var sumArr = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                sumArr[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}