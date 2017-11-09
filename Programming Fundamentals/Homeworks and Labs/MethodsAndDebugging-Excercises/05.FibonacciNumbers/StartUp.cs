namespace _05.FibonacciNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintFibNumber(number));
        }

        private static long PrintFibNumber(long num)
        {
            var fibOne = 1;
            var fibTwo = 1;
            var fibNext = fibOne + fibTwo;

            for (int i = 0; i < num - 1; i++)
            {
                fibNext = fibOne + fibTwo;
                fibOne = fibTwo;
                fibTwo = fibNext;
            }

            return fibTwo;
        }
    }
}