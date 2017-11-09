namespace _12.MasterNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int num)
        {
            var isPalindrome = true;
            var number = num.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }

            return isPalindrome;
        }

        private static bool SumOfDigits(int num)
        {
            var sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            var containsEven = false;

            while (num > 0)
            {
                var lastDigit = num % 10;

                if (lastDigit % 2 == 0)
                {
                    containsEven = true;
                }
                num /= 10;
            }

            return containsEven;
        }
    }
}