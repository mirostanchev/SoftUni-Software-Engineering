﻿namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                var command = input[0];

                if (command == "A")
                {
                    var name = input[1];
                    var number = input[2];

                    phonebook[name] = number;
                }
                else if (command == "S")
                {
                    var name = input[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}