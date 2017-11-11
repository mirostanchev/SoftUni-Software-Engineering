namespace _13.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split();
            var result = new Dictionary<char, char>();
            var shorter = sequence[0];
            var longer = sequence[1];

            if (shorter.Length > longer.Length)
            {
                var temp = longer;
                longer = shorter;
                shorter = temp;
            }

            var areExchangable = true;

            for (int i = 0; i < shorter.Length; i++)
            {
                if (!result.ContainsKey(longer[i]))
                {
                    result[longer[i]] = shorter[i];
                }
                else if (result[longer[i]] != shorter[i])
                {
                    areExchangable = false;
                    break;
                }

            }

            if (areExchangable)
            {
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    if (!result.ContainsKey(longer[i]))
                    {
                        areExchangable = false;
                        break;
                    }
                }
            }

            Console.WriteLine(areExchangable.ToString().ToLower());
        }
    }
}