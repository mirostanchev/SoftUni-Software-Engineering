namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetTrailingZeroes(num));
        }

        private static int GetTrailingZeroes(int n)
        {
            BigInteger sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            var count = 0;

            while (sum % 10 == 0)
            {
                count++;
                sum /= 10;
            }

            return count;
        }
    }
}