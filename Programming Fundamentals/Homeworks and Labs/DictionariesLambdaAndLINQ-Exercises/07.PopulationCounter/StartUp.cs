namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var population = new Dictionary<string, Dictionary<string, long>>();

            while (!inputLine.Equals("report"))
            {
                var lineArgs = inputLine.Split('|').ToArray();

                var country = lineArgs[1];
                var city = lineArgs[0];
                var populationCount = int.Parse(lineArgs[2]);

                if (!population.ContainsKey(country))
                {
                    population.Add(country, new Dictionary<string, long>());
                }

                if (!population[country].ContainsKey(city))
                {
                    population[country].Add(city, 0);
                }

                population[country][city] += populationCount;

                inputLine = Console.ReadLine();
            }

            population = population
                .OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var country in population)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}