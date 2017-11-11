namespace _14.DragonArmy
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, DragonStats>>();

            for (int i = 0; i < n; i++)
            {
                var dragonInfo = Console.ReadLine().Split();

                var dragonType = dragonInfo[0];
                var dragonName = dragonInfo[1];

                var damage = 45;
                var health = 250;
                var armor = 10;

                if (dragonInfo[2] != "null")
                {
                    damage = int.Parse(dragonInfo[2]);
                }
                if (dragonInfo[3] != "null")
                {
                    health = int.Parse(dragonInfo[3]);
                }
                if (dragonInfo[4] != "null")
                {
                    armor = int.Parse(dragonInfo[4]);
                }

                if (!dragons.ContainsKey(dragonType))
                {
                    dragons[dragonType] = new SortedDictionary<string, DragonStats>();
                }
                if (!dragons[dragonType].ContainsKey(dragonName))
                {
                    dragons[dragonType][dragonName] = new DragonStats();
                }

                dragons[dragonType][dragonName] = new DragonStats() { Damage = damage, Armor = armor, Health = health };
            }

            foreach (var dragon in dragons)
            {
                var averageArmor = dragon.Value.Average(x => x.Value.Armor);
                var averageDamage = dragon.Value.Average(x => x.Value.Damage);
                var averageHealth = dragon.Value.Average(x => x.Value.Health);

                Console.WriteLine($"{dragon.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var item in dragon.Value)
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value.Damage}, health: {item.Value.Health}, armor: {item.Value.Armor}");
                }
            }
        }
    }
}