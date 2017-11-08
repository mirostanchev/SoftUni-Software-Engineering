namespace _08.OddEvenSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;

            for (int i = 1; i <= number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else if (i % 2 != 0)
                {
                    oddSum += currentNumber;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}