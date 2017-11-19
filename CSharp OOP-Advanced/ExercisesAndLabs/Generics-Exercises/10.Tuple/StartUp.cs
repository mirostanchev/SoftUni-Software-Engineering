namespace _10.Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var tokens = GetTokens();
            var tupleOne = new CustomTuple<string, string>((tokens[0] + " " + tokens[1]), tokens[2]);

            tokens = GetTokens();
            var tupleTwo = new CustomTuple<string, int>(tokens[0], int.Parse(tokens[1]));

            tokens = GetTokens();
            var tupleThree = new CustomTuple<int, double>(int.Parse(tokens[0]), double.Parse(tokens[1]));

            Console.WriteLine(tupleOne.ToString());
            Console.WriteLine(tupleTwo.ToString());
            Console.WriteLine(tupleThree.ToString());
        }

        private static List<string> GetTokens()
        {
            return Console.ReadLine().Split(new[] { ' ' }).ToList();
        }
    }
}