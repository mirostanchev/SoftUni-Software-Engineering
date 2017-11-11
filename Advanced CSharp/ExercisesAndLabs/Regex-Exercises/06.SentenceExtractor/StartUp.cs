namespace _06.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var sentence = Console.ReadLine();

            var pattern = $@"[a-zA-Z0-9 ]+\b{keyword}\b.*?[?!.]";
            var regex = new Regex(pattern);
            var matches = regex.Matches(sentence);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
        }
    }
}