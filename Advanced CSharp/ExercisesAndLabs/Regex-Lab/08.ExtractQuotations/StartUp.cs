namespace _08.ExtractQuotations
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var reg = new Regex("'(.+?)'|\"(.+?)\"");
            var inputLine = Console.ReadLine();

            var sb = new StringBuilder();

            while (!string.IsNullOrEmpty(inputLine))
            {
                foreach (Match match in reg.Matches(inputLine))
                {
                    var firstGroup = match.Groups[1].Value;
                    var secondGroup = match.Groups[2].Value;

                    if (firstGroup.Length > 0) sb.AppendLine(firstGroup);
                    if (secondGroup.Length > 0) sb.AppendLine(secondGroup);
                }

                inputLine = Console.ReadLine();
            }

            Console.Write(sb);
        }
    }
}