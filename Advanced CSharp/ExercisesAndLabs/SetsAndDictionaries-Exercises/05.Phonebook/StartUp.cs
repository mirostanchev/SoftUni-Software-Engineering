namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "search")
                {
                    break;
                }

                var commandArgs = command.Split('-');
                var name = commandArgs[0];
                var number = commandArgs[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }

                phonebook[name] = number;
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "stop" || command == "Stop")
                {
                    break;
                }

                string expectedValue;

                if (phonebook.TryGetValue(command, out expectedValue))
                {
                    Console.WriteLine($"{command} -> {phonebook[command]}");
                }
                else
                {
                    Console.WriteLine($"Contact {command} does not exist.");
                }
            }
        }
    }
}