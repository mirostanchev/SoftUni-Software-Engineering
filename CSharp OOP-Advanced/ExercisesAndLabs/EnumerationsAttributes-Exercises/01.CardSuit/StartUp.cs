namespace _01.CardSuit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var values = Enum.GetValues(typeof(CardSuit));

            Console.WriteLine("Card Suits:");

            foreach (var value in values)
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}