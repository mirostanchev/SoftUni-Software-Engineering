namespace _11.EqualSums
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var isFound = false;

            for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                var leftSum = 0;
                var rightSum = 0;

                for (int i = 0; i < currentElement; i++)
                {
                    leftSum += numbers[i];
                }

                for (int i = currentElement + 1; i < numbers.Length; i++)
                {
                    rightSum += numbers[i];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(currentElement);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}