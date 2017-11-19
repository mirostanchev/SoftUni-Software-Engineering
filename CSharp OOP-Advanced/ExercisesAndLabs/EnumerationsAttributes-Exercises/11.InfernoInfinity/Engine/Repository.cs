namespace _11.InfernoInfinity.Engine
{
    using System.Collections.Generic;
    using System.Linq;
    using _11.InfernoInfinity.Factories;
    using _11.InfernoInfinity.Models.Gems;
    using _11.InfernoInfinity.Models.Weapons;

    public class Repository
    {
        private readonly List<Weapon> weapons;
        private readonly WeaponFactory weaponFactory;
        private readonly GemFactory gemFactory;

        public Repository()
        {
            this.weapons = new List<Weapon>();
            this.weaponFactory = new WeaponFactory();
            this.gemFactory = new GemFactory();
        }

        public void Create(List<string> tokens)
        {
            Weapon weapon = this.weaponFactory.Create(tokens);
            this.weapons.Add(weapon);
        }

        public void Add(List<string> tokens)
        {
            var weaponName = tokens[0];
            var index = int.Parse(tokens[1]);
            var gemArguments = tokens[2];
            Gem gem = this.gemFactory.Create(gemArguments);
            var currentWeapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
            currentWeapon.AddGem(index, gem);
        }

        public void Remove(List<string> tokens)
        {
            var weaponName = tokens[0];
            var index = int.Parse(tokens[1]);
            var currentWeapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
            currentWeapon.RemoveGem(index);
        }

        public string Print(string name)
        {
            var printWeapon = this.weapons.FirstOrDefault(w => w.Name == name);
            printWeapon.CalculateStats();
            return $"{printWeapon}";
        }
    }
}