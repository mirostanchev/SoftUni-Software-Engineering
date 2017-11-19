namespace _11.Threeuple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var tokens = GetTokens();
            var name = tokens[0] + " " + tokens[1];
            var adress = tokens[2];
            var town = tokens[3];
            var tupleOne = new CustomTuple<string, string, string>(name, adress, town);

            tokens = GetTokens();
            name = tokens[0];
            var beers = int.Parse(tokens[1]);
            var drunkOrNot = tokens[2];
            var isDrunk = false;

            if (drunkOrNot == "drunk")
            {
                isDrunk = true;
            }

            var tupleTwo = new CustomTuple<string, int, bool>(name, beers, isDrunk);

            tokens = GetTokens();
            name = tokens[0];
            var balance = double.Parse(tokens[1]);
            var bankName = tokens[2];
            var tupleThree = new CustomTuple<string, double, string>(name, balance, bankName);

            Console.WriteLine(tupleOne.ToString());
            Console.WriteLine(tupleTwo.ToString());
            Console.WriteLine(tupleThree.ToString());
        }

        private static List<string> GetTokens()
        {
            return Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}