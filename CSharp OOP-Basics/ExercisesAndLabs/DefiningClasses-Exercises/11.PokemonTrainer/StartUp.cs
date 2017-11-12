namespace _11.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new List<Trainer>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Tournament")
                {
                    break;
                }

                var lineArgs = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = lineArgs[0];
                var pokemonName = lineArgs[1];
                var pokemonElement = lineArgs[2];
                var pokemonHealth = int.Parse(lineArgs[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                var trainer = new Trainer(trainerName, pokemon);
                
                if (result.Any(x => x.Name == trainerName))
                {
                    result.Find(x => x.Name == trainerName).Pokemons.Add(pokemon);
                }
                else
                {
                    result.Add(trainer);
                }
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in result)
                {
                    if (trainer.ContainsElement(command))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.DecreaseHealth();
                    }

                    trainer.RemovePokemons();
                }
            }

            foreach (var trainer in result.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}