namespace _11.InfernoInfinity.Models.Gems
{
    using _11.InfernoInfinity.Enums;

    public abstract class Gem
    {
        protected Gem(Clarity clarity, int strenght, int agility, int vitality)
        {
            this.clarity = clarity;
            this.Strength = strenght;
            this.Agility = agility;
            this.Vitality = vitality;
            this.SetClarity();
        }

        public Clarity clarity;
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }

        private void SetClarity()
        {
            var statClarity = (int)this.clarity;
            this.Strength += statClarity;
            this.Agility += statClarity;
            this.Vitality += statClarity;
        }
    }
}