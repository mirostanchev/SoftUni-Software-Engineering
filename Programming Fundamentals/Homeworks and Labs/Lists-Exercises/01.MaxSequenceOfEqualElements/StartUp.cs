namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var longestSeq = GetLongestSequence(numbers);

            Console.WriteLine(string.Join(" ", longestSeq));
        }

        public static List<int> GetLongestSequence(List<int> numbers)
        {
            var maxLen = 1;
            var maxIndex = 0;
            var currentLen = 1;
            var currentIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLen++;
                }
                else
                {
                    currentIndex = i;
                    currentLen = 1;
                }

                if (maxLen < currentLen)
                {
                    maxLen = currentLen;
                    maxIndex = currentIndex;
                }
            }

            var longestSeq = new List<int>();

            for (int len = 0; len < maxLen; len++)
            {
                longestSeq.Add(numbers[maxIndex + len]);
            }

            return longestSeq;
        }
    }
}