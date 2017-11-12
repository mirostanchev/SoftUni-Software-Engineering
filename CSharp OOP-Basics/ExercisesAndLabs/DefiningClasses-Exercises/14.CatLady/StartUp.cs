namespace _14.CatLady
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, Cat>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var commandArgs = command.Split();
                var catType = commandArgs[0];

                if (catType == "StreetExtraordinaire")
                {
                    var name = commandArgs[1];
                    var decibels = int.Parse(commandArgs[2]);

                    var cat = new Cat();
                    cat.Type = catType;
                    cat.Name = name;
                    cat.Decibels = decibels;

                    result.Add(name, cat);
                }
                else if (catType == "Siamese")
                {
                    var name = commandArgs[1];
                    var earSize = int.Parse(commandArgs[2]);

                    var cat = new Cat();
                    cat.Type = catType;
                    cat.Name = name;
                    cat.EarSize = earSize;

                    result.Add(name, cat);
                }
                else
                {
                    var name = commandArgs[1];
                    var furSize = double.Parse(commandArgs[2]);

                    var cat = new Cat();
                    cat.Type = catType;
                    cat.Name = name;
                    cat.FurSize = furSize;

                    result.Add(name, cat);
                }
            }

            var searchedName = Console.ReadLine();
            var searchedCat = result[searchedName];

            Console.Write($"{searchedCat.Type} {searchedCat.Name} ");

            if (searchedCat.Type == "StreetExtraordinaire")
            {
                Console.WriteLine(searchedCat.Decibels);
            }
            else if (searchedCat.Type == "Cymric")
            {
                Console.WriteLine($"{searchedCat.FurSize:f2}");
            }
            else
            {
                Console.WriteLine(searchedCat.EarSize);
            }
        }
    }
}