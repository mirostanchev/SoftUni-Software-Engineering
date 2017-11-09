namespace _08.MostFrequentNumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var counts = new int[65535];
            var maxCount = 0;
            var frequentNumber = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                counts[sequence[i]]++;

                if (counts[sequence[i]] > maxCount)
                {
                    maxCount = counts[sequence[i]];
                    frequentNumber = sequence[i];
                }
            }

            Console.WriteLine(frequentNumber);
        }
    }
}