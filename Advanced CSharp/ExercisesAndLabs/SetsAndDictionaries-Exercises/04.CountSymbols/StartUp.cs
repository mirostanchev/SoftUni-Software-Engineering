namespace _04.CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];

                if (!result.ContainsKey(symbol))
                {
                    result[symbol] = 0;
                }

                result[symbol]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}