namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endIndex = int.Parse(Console.ReadLine());

            if (startIndex >= endIndex)
            {
                Console.WriteLine("(empty list)");
            }

            var result = FindPrimesInRange(startIndex, endIndex);
            Console.WriteLine(string.Join(", ", result));
        }

        private static bool IsPrime(int number)
        {
            if (number == 1 || number == 0)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            
            for (int i = 2; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        private static List<int> FindPrimesInRange(int startNumber, int endNumber)
        {
            var numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}