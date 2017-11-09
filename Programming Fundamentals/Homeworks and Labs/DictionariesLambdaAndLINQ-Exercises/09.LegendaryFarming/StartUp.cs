namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var goodMaterials = new Dictionary<string, int>();

            goodMaterials["shards"] = 0;
            goodMaterials["motes"] = 0;
            goodMaterials["fragments"] = 0;

            var junkMaterials = new SortedDictionary<string, int>();

            while (true)
            {
                var resources = Console.ReadLine().ToLower()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 0; i < resources.Count; i += 2)
                {
                    var resourceType = resources[i + 1];
                    var resourceQuantity = int.Parse(resources[i]);

                    if (resourceType == "shards" || resourceType == "motes" || resourceType == "fragments")
                    {
                        goodMaterials[resourceType] += resourceQuantity;

                        if (goodMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            goodMaterials["shards"] -= 250;
                            PrintMaterials(goodMaterials, junkMaterials);
                            return;
                        }

                        if (goodMaterials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            goodMaterials["fragments"] -= 250;
                            PrintMaterials(goodMaterials, junkMaterials);
                            return;
                        }

                        if (goodMaterials["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            goodMaterials["motes"] -= 250;
                            PrintMaterials(goodMaterials, junkMaterials);
                            return;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(resourceType))
                        {
                            junkMaterials[resourceType] = resourceQuantity;
                        }
                        else
                        {
                            junkMaterials[resourceType] += resourceQuantity;
                        }
                    }
                }
            }
        }

        private static void PrintMaterials(Dictionary<string, int> goodMaterials, SortedDictionary<string, int> junkMaterials)
        {
            foreach (var kvp in goodMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}