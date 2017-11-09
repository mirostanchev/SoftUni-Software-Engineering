namespace _08.MultiplyEvensByOdds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultiply(num));
        }

        private static int GetSumOfOddDigits(int num)
        {
            var sum = 0;

            while (Math.Abs(num) > 0)
            {
                var lastDigit = num % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num = num / 10;
            }

            return sum;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            var sum = 0;

            while (Math.Abs(num) > 0)
            {
                var lastDigit = num % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num = num / 10;
            }

            return sum;
        }

        private static int GetMultiply(int num)
        {
            var sumOdd = GetSumOfOddDigits(num);
            var sumEven = GetSumOfEvenDigits(num);
            var multiply = Math.Abs(sumEven * sumOdd);

            return multiply;
        }
    }
}