namespace _06.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new List<IPerson>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var cmdArgs = command.Split();

                if (cmdArgs[0] == "Citizen")
                {
                    IPerson citizen = new Citizen(cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3], cmdArgs[4]);
                    result.Add(citizen);
                }
                else if (cmdArgs[0] == "Pet")
                {
                    IPerson pet = new Pet(cmdArgs[1], cmdArgs[2]);
                    result.Add(pet);
                }
            }

            var year = Console.ReadLine();

            foreach (var item in result)
            {
                if (item.Birthdate.Split('/').Last() == year)
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}