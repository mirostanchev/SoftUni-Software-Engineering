namespace _06.FootballTeamGenerator
{
    using System;

    public class Player
    {
        private string name;
        private Stats stats;
        private double skillLevel;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.stats = stats;
            this.skillLevel = (stats.Dribble + stats.Endurance + stats.Passing + stats.Shooting + stats.Sprint) / 5.0;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public Stats Stats
        {
            get { return this.stats; }
        }

        public double SkillLevel
        {
            get { return this.skillLevel; }
        }
    }
}