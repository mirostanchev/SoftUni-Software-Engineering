namespace _12.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var resources = new Dictionary<string, long>();
            var junkResources = new Dictionary<string, long>();

            resources["fragments"] = 0;
            resources["motes"] = 0;
            resources["shards"] = 0;

            var output = "";

            while (true)
            {
                var resourcesInfo = Console.ReadLine().Split();

                for (int i = 1; i < resourcesInfo.Length; i += 2)
                {
                    var quantity = long.Parse(resourcesInfo[i - 1]);
                    var material = resourcesInfo[i].ToLower();
                    
                    if (resources.Values.Any(x => x >= 250))
                    {
                        break;
                    }

                    if (material == "motes" || material == "fragments" || material == "shards")
                    {
                        resources[material] += quantity;
                    }
                    else
                    {
                        if (!junkResources.ContainsKey(material))
                        {
                            junkResources[material] = 0;
                        }

                        junkResources[material] += quantity;
                    }
                }

                var isFound = false;

                if (resources["motes"] >= 250)
                {
                    resources["motes"] -= 250;
                    output = "Dragonwrath";
                    isFound = true;
                }
                if (resources["fragments"] >= 250)
                {
                    resources["fragments"] -= 250;
                    output = "Valanyr";
                    isFound = true;

                }
                if (resources["shards"] >= 250)
                {
                    resources["shards"] -= 250;
                    output = "Shadowmourne";
                    isFound = true;
                }

                if (isFound)
                {
                    break;
                }
            }

            Console.WriteLine($"{output} obtained!");

            foreach (var resource in resources.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }

            foreach (var resource in junkResources.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }
        }
    }
}