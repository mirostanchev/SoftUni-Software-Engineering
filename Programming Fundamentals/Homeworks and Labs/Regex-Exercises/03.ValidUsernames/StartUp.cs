﻿namespace _03.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var usernames = Console.ReadLine()
                .Split(new char[] { '\\', '/', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var validUsernames = new List<string>();
            var pattern = @"^[A-Za-z][A-Za-z\d_]{2,24}$";
            var regex = new Regex(pattern);

            for (int i = 0; i < usernames.Length; i++)
            {
                if (regex.IsMatch(usernames[i]))
                {
                    validUsernames.Add(usernames[i]);
                }
            }

            var maxLenght = 0;
            var startIndex = 0;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                if (validUsernames[i].Length + validUsernames[i + 1].Length > maxLenght)
                {
                    maxLenght = validUsernames[i].Length + validUsernames[i + 1].Length;
                    startIndex = i;
                }
            }

            Console.WriteLine(validUsernames[startIndex].Trim());
            Console.WriteLine(validUsernames[startIndex + 1].Trim());
        }
    }
}