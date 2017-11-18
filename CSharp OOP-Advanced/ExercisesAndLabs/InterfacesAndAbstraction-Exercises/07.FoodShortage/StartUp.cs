namespace _07.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, IBuyer>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                if (cmdArgs.Length == 4)
                {
                    IBuyer citizen = new Citizen(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2], cmdArgs[3]);
                    result[cmdArgs[0]] = citizen;
                }
                else
                {
                    IBuyer rebel = new Rebel(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                    result[cmdArgs[0]] = rebel;
                }
            }

            while (true)
            {
                var name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                if (result.ContainsKey(name))
                {
                    result[name].BuyFood();
                }
            }

            Console.WriteLine(result.Sum(x => x.Value.Food));
        }
    }
}