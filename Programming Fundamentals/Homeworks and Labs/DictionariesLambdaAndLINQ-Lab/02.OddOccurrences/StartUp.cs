namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();

            var wordsCount = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!wordsCount.ContainsKey(item))
                {
                    wordsCount[item] = 0;
                }

                wordsCount[item]++;
            }

            var result = new List<string>();

            foreach (var word in wordsCount)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}