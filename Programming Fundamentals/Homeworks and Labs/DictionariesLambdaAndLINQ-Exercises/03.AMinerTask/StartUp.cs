namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var resources = new Dictionary<string, decimal>();
            var resourceType = Console.ReadLine();

            while (resourceType != "stop")
            {
                var resourceQuantity = decimal.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceType))
                {
                    resources[resourceType] = 0;
                }

                resources[resourceType] += resourceQuantity;
                resourceType = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}