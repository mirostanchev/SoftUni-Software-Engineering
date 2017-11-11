namespace _02.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"^\+359(-| )2\1\d{3}\1\d{4}$";
            var regex = new Regex(pattern);

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}