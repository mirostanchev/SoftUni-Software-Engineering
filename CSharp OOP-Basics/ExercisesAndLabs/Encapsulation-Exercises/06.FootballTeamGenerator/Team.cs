namespace _06.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public double Rating
        {
            get
            {
                return players.Count == 0 ? 0 : Math.Round(this.players.Average(x => x.SkillLevel), 0);
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemomePlayer(string player)
        {
            if (this.players.Any(x => x.Name == player))
            {
                var searchedPlayer = this.players.First(x => x.Name == player);
                this.players.Remove(searchedPlayer);
            }
            else
            {
                throw new ArgumentException($"Player {player} is not in {this.name} team.");
            }
        }
    }
}