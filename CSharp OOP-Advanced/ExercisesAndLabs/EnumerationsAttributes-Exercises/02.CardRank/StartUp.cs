namespace _02.CardRank
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var values = Enum.GetValues(typeof(CardRank));

            Console.WriteLine("Card Ranks:");

            foreach (var value in values)
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}