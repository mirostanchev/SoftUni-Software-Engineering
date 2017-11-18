namespace _10.ExplicitInterfaces
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var cmdArgs = command.Split();

                IPerson person = new Citizen(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                IResident resident = new Citizen(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }

        }
    }
}