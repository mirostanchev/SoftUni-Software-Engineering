﻿namespace _11.InfernoInfinity.Factories
{
    using System;
    using _11.InfernoInfinity.Enums;
    using _11.InfernoInfinity.Models.Gems;

    public class GemFactory
    {
        public Gem Create(string arguments)
        {
            var tokens = arguments.Split();
            var clarityType = tokens[0];
            var gemType = tokens[1];
            var clarity = (Clarity)Enum.Parse(typeof(Clarity), clarityType);

            Gem gem = null;

            switch (gemType)
            {
                case "Ruby":
                    gem = new RubyGem(clarity);
                    break;

                case "Emerald":
                    gem = new EmeraldGem(clarity);
                    break;

                case "Amethyst":
                    gem = new AmethystGem(clarity);
                    break;
            }

            return gem;
        }
    }
}