namespace _11.InfernoInfinity.Models.Weapons
{
    using _11.InfernoInfinity.Enums;

    public class Sword : Weapon
    {
        private const int MinDamage = 4;
        private const int MaxDamage = 6;
        private const int NumberOfSockets = 3;

        public Sword(Rarity rarity, string name)
            : base(rarity, name, MinDamage, MaxDamage, NumberOfSockets)
        {
        }
    }
}