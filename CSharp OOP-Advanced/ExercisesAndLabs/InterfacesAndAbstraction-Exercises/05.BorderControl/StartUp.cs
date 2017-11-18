namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;

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

                if (cmdArgs.Length == 3)
                {
                    IPerson citizen = new Citizen(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                    result.Add(citizen);
                }
                else
                {
                    IPerson robot = new Robot(cmdArgs[0], cmdArgs[1]);
                    result.Add(robot);
                }
            }

            var lastNums = Console.ReadLine();

            foreach (var item in result)
            {
                if (item.Id.EndsWith(lastNums))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}