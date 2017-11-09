namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var sequance = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var maxStart = 0;
            var maxLen = 1;
            var currentStart = 0;
            var currentLen = 1;

            for (int i = 1; i < sequance.Length; i++)
            {
                if (sequance[i] > sequance[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentStart = i;
                }
            }

            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write("{0} ", sequance[i]);
            }
        }
    }
}