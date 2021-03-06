﻿namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"^[A-Z][a-z]+ [A-Z][a-z]+$";
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