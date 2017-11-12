namespace _11.PokemonTrainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons = new List<Pokemon>();

        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.Pokemons.Add(pokemon);
        }

        public List<Pokemon> Pokemons { get => this.pokemons; set => this.pokemons = value; }
        public string Name { get => this.name; set => this.name = value; }
        public int NumberOfBadges { get => this.numberOfBadges; set => this.numberOfBadges = value; }

        public void RemovePokemons()
        {
            this.pokemons = this.pokemons.Where(x => x.Health > 0).ToList();
        }

        public bool ContainsElement(string element)
        {
            foreach (var pokemon in this.pokemons)
            {
                if (pokemon.Element == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void DecreaseHealth()
        {
            foreach (var pokemon in this.pokemons)
            {
                pokemon.Health -= 10;
            }
        }
    }
}