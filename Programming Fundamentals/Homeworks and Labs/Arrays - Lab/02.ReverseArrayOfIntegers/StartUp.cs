namespace _02.ReverseArrayOfIntegers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];
            var reversedNumbers = new int[numbers.Length];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                reversedNumbers[i] = numbers[n - 1 - i];
                Console.Write(reversedNumbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}