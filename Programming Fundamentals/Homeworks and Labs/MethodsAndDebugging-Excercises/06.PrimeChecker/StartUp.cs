namespace _06.PrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(long num)
        {
            if (num < 2)
            {
                return false;
            }

            var isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}