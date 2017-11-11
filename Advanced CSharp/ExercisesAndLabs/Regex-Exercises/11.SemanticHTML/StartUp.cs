namespace _11.SemanticHTML
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var openingPattern = @"<(div)([^>]+)(?:id|class)\s*=\s*""(.*?)""(.*?)>";
            var closingPattern = @"<\/div>\s*<!--\s*(.*?)\s*-->";

            while (line != "END")
            {
                var openingMatch = Regex.Match(line, openingPattern);
                var closingMatch = Regex.Match(line, closingPattern);

                if (openingMatch.Success)
                {
                    line = Regex.Replace(line, openingPattern, @"$3 $2 $4").Trim();
                    line = "<" + Regex.Replace(line, @"\s+", " ") + ">";
                }
                else if (closingMatch.Success)
                {
                    line = "</" + closingMatch.Groups[1] + ">";
                }

                Console.WriteLine(line);
                line = Console.ReadLine();
            }
        }
    }
}