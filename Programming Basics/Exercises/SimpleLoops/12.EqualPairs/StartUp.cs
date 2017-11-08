namespace _12.EqualPairs
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var previousSum = 0;
            var currentSum = 0;
            var currentDiff = 1;
            var maxDiff = 0;

            for (int i = 0; i < number; i++)
            {
                previousSum = currentSum;
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());

                currentSum = firstNumber + secondNumber;
                currentDiff = Math.Abs(currentSum - previousSum);

                if (currentDiff > maxDiff && i >= 1)
                {
                    maxDiff = currentDiff;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value=" + currentSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
        }
    }
}