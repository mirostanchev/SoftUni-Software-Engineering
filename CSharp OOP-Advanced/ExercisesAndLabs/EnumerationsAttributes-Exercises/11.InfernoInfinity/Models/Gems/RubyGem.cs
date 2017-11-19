namespace _11.InfernoInfinity.Models.Gems
{
    using _11.InfernoInfinity.Enums;

    public class RubyGem : Gem
    {
        private const int Strength = 7;
        private const int Agility = 2;
        private const int Vitality = 5;

        public RubyGem(Clarity clarity)
            : base(clarity, Strength, Agility, Vitality)
        {
        }
    }
}