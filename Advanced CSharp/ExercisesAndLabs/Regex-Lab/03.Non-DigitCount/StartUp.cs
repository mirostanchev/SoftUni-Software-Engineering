namespace _03.Non_DigitCount
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"\D";
            var reg = new Regex(pattern);
            var matchesCount = reg.Matches(text).Count;

            Console.WriteLine($"Non-digits: {matchesCount}");
        }
    }
}