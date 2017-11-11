namespace _04.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"<a.href=""(.+?)"">(.+?)<\/a>";
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
                    Console.WriteLine(regex.Replace(input, "[URL href=\"$1\"]$2[/URL]"));
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}