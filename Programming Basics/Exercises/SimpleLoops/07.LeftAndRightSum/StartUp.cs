namespace _07.LeftAndRightSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                leftSum += currentNumber;
            }

            for (int i = 0; i < number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                rightSum += currentNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}