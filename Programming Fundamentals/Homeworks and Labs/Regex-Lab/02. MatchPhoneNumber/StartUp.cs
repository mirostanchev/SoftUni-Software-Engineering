namespace _02.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"\+\d{3}(\s|-)\d{1}\1\d{3}\1\d{4}(?!\d)";
            var input = Console.ReadLine();
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}