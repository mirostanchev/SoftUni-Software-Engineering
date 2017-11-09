namespace _01.LargestCommonEnd
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var arrOne = Console.ReadLine().Split();
            var arrTwo = Console.ReadLine().Split();

            var length = Math.Min(arrOne.Length, arrTwo.Length);
            var leftCounter = 0;
            leftCounter = CalcEqualsWord(arrOne, arrTwo, length, leftCounter);

            Array.Reverse(arrOne);
            Array.Reverse(arrTwo);

            var rightCounter = 0;
            rightCounter = CalcEqualsWord(arrOne, arrTwo, length, rightCounter);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }

        public static int CalcEqualsWord(string[] arr1, string[] arr2, int length, int rightCounter)
        {
            for (int i = 0; i < length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    rightCounter++;
                }
            }

            return rightCounter;
        }
    }
}