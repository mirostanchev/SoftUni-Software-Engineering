namespace _10.PopulationCounter
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "report")
                {
                    break;
                }

                var info = command.Split('|');

                var city = info[0];
                var country = info[1];
                var population = long.Parse(info[2]);

                if (!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string, long>();
                }

                if (!result[country].ContainsKey(city))
                {
                    result[country][city] = 0;
                }

                result[country][city] += population;
            }

            foreach (var outer in result.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{outer.Key} (total population: {outer.Value.Values.Sum()})");

                foreach (var inner in outer.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{inner.Key}: {inner.Value}");
                }
            }
        }
    }
}