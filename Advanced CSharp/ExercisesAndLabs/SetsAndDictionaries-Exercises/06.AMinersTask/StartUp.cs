namespace _06.AMinersTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var mine = new Dictionary<string, long>();
            var resource = Console.ReadLine();

            while (resource != "stop")
            {
                var quantity = long.Parse(Console.ReadLine());

                if (!mine.ContainsKey(resource))
                {
                    mine[resource] = 0;
                }

                mine[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var item in mine)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}