namespace _10.UseYourChainsBuddy
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex("<p>(.*?)<\\/p>");
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var whitespaces = "[^a-z0-9]";
                var reminder = match.Groups[1].Value;
                var replaced = Regex.Replace(reminder, whitespaces, " ");
                var pattern = @"\s+";
                replaced = Regex.Replace(replaced, pattern, " ");

                foreach (var character in replaced)
                {
                    if (character >= 'a' && character <= 'm')
                    {
                        Console.Write((char)(character + 13));
                    }
                    else if (character >= 'n' && character <= 'z')
                    {
                        Console.Write((char)(character - 13));
                    }
                    else
                    {
                        Console.Write(character);
                    }
                }
            }
        }
    }
}