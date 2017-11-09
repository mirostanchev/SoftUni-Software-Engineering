namespace _02.RotateAndSum
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
            var rotations = int.Parse(Console.ReadLine());

            var sumArr = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                var lastElement = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j >= 1; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = lastElement;

                for (int k = 0; k < numbers.Length; k++)
                {
                    sumArr[k] += numbers[k];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}