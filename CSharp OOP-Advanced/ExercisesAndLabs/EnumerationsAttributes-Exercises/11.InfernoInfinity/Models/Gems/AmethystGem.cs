﻿namespace _11.InfernoInfinity.Models.Gems
{
    using _11.InfernoInfinity.Enums;

    public class AmethystGem : Gem
    {
        private const int Strength = 2;
        private const int Agility = 8;
        private const int Vitality = 4;

        public AmethystGem(Clarity clarity)
            : base(clarity, Strength, Agility, Vitality)
        {
        }
    }
}