namespace _04.NumbersInReversedOrder
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            PrintReversedNumber(number);
        }

        private static void PrintReversedNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i]);
            }

            Console.WriteLine();
        }
    }
}