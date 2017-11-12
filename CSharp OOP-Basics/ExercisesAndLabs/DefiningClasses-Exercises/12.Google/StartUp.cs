namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new List<Person>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var commandArgs = command.Split();
                var personName = commandArgs[0];

                if (result.All(x => x.Name != personName))
                {
                    result.Add(new Person(personName));
                }

                if (commandArgs[1] == "company")
                {
                    var companyName = commandArgs[2];
                    var companyDepartment = commandArgs[3];
                    var salary = decimal.Parse(commandArgs[4]);

                    result.Find(x => x.Name == personName).Company.Name = companyName;
                    result.Find(x => x.Name == personName).Company.Department = companyDepartment;
                    result.Find(x => x.Name == personName).Company.Salary = salary;
                }
                else if (commandArgs[1] == "pokemon")
                {
                    var pokemonName = commandArgs[2];
                    var pokemonType = commandArgs[3];

                    var pokemon = new Pokemon(pokemonName, pokemonType);
                    result.Find(x => x.Name == personName).Pokemon.Add(pokemon);

                }
                else if (commandArgs[1] == "parents")
                {
                    var parentName = commandArgs[2];
                    var parentBirthday = commandArgs[3];

                    var parent = new Parents(parentName, parentBirthday);
                    result.Find(x => x.Name == personName).Parents.Add(parent);

                }
                else if (commandArgs[1] == "children")
                {
                    var childName = commandArgs[2];
                    var childBirthday = commandArgs[3];

                    var child = new Children(childName, childBirthday);
                    result.Find(x => x.Name == personName).Children.Add(child);
                }
                else
                {
                    var carModel = commandArgs[2];
                    var carSpeed = int.Parse(commandArgs[3]);

                    result.Find(x => x.Name == personName).Car.Model = carModel;
                    result.Find(x => x.Name == personName).Car.Speed = carSpeed;
                }
            }

            var searchedName = Console.ReadLine();
            var searchedPerson = result.Find(x => x.Name == searchedName);

            Console.WriteLine(searchedPerson.Name);
            Console.WriteLine("Company:");
            if (searchedPerson.Company.Name != null)
            {
                Console.WriteLine($"{searchedPerson.Company.Name} {searchedPerson.Company.Department} {searchedPerson.Company.Salary:f2}");
            }
            Console.WriteLine("Car:");
            if (searchedPerson.Car.Model != null)
            {
                Console.WriteLine($"{searchedPerson.Car.Model} {searchedPerson.Car.Speed}");
            }
            Console.WriteLine("Pokemon:");

            foreach (var pokemon in searchedPerson.Pokemon)
            {
                Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
            }

            Console.WriteLine("Parents:");

            foreach (var parent in searchedPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }

            Console.WriteLine("Children:");

            foreach (var child in searchedPerson.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
    }
}