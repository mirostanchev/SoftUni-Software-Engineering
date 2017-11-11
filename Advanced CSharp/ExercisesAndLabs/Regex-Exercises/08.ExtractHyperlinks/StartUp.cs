﻿namespace _08.ExtractHyperlinks
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var sb = new StringBuilder();

            while (line != "END")
            {
                sb.Append(line).Append(" ");
                line = Console.ReadLine();
            }

            var matches = Regex.Matches(sb.ToString(), @"<a\s+[^>]*?href\s*=(.*?)>.*?<\s*\/\s*a\s*>");

            foreach (Match match in matches)
            {
                var candidateHref = match.Groups[1].Value.Trim();

                if (candidateHref[0] == '"')
                {
                    Console.WriteLine(candidateHref
                        .Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries)
                        .First());
                }
                else if (candidateHref[0] == '\'')
                {
                    Console.WriteLine(candidateHref
                        .Split(new[] { '\'' }, StringSplitOptions.RemoveEmptyEntries)
                        .First());
                }
                else
                {
                    Console.WriteLine(Regex.Split(candidateHref, @"\s+").First());
                }
            }
        }
    }
}