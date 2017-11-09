namespace _02.LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var len = new int[sequence.Length];
            var prev = new int[sequence.Length];
            var maxLen = 1;
            var lastIndex = 0;

            for (int currentIndex = 0; currentIndex < sequence.Length; currentIndex++)
            {
                len[currentIndex] = 1;
                prev[currentIndex] = -1;

                for (int prevIndex = 0; prevIndex < currentIndex; prevIndex++)
                {
                    if (sequence[prevIndex] < sequence[currentIndex] &&
                        len[prevIndex] >= len[currentIndex])
                    {
                        len[currentIndex]++;
                        prev[currentIndex] = prevIndex;
                    }

                    if (len[currentIndex] > maxLen)
                    {
                        maxLen = len[currentIndex];
                        lastIndex = currentIndex;
                    }
                }
            }

            var longestIncreasingSeq = GetLongestIncreasingSequence(sequence, prev, lastIndex);

            Console.WriteLine(string.Join(" ", longestIncreasingSeq));
        }

        public static List<int> GetLongestIncreasingSequence(int[] sequence, int[] prev, int lastIndex)
        {
            var longestIncreasingSeq = new List<int>();

            while (lastIndex != -1)
            {
                longestIncreasingSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestIncreasingSeq.Reverse();
            return longestIncreasingSeq;
        }
    }
}