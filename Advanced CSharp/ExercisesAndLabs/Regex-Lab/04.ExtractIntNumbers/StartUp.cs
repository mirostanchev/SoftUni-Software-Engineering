namespace _04.ExtractIntNumbers
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"\d+";
            var matches = Regex.Matches(text, pattern);

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.AppendLine(match.Groups[0].Value);
            }

            Console.Write(sb);
        }
    }
}