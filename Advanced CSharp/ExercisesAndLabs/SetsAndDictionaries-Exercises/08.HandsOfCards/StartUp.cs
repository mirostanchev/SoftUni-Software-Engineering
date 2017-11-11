namespace _08.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var participantInfo = Console.ReadLine().Split(':');

                if (participantInfo[0] == "JOKER")
                {
                    break;
                }

                var name = participantInfo[0].Trim();
                var playCards = participantInfo[1]
                    .Trim()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!result.ContainsKey(name))
                {
                    result[name] = new HashSet<string>();
                }

                for (int i = 0; i < playCards.Length; i++)
                {
                    result[name].Add(playCards[i]);
                }
            }

            var playerPoints = new Dictionary<string, int>();

            foreach (var player in result)
            {
                var name = player.Key;
                var score = 0;

                foreach (var card in player.Value)
                {
                    var length = card.Length;
                    var powerScore = 0;

                    if (length == 2)
                    {
                        var power = card.Substring(0, 1);
                        powerScore = GetPower(power);
                    }
                    else if (length == 3)
                    {
                        var power = card.Substring(0, 2);
                        powerScore = GetPower(power);
                    }

                    var type = card[card.Length - 1];
                    var typeScore = GetType(type);

                    score = typeScore * powerScore;

                    if (!playerPoints.ContainsKey(name))
                    {
                        playerPoints[name] = 0;
                    }

                    playerPoints[name] += score;
                }
            }

            foreach (var player in playerPoints)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }

        private static int GetPower(string str)
        {
            var points = 0;

            if (str == "J")
            {
                points = 11;
            }
            else if (str == "Q")
            {
                points = 12;
            }
            else if (str == "K")
            {
                points = 13;
            }
            else if (str == "A")
            {
                points = 14;
            }
            else
            {
                points = int.Parse(str);
            }

            return points;
        }

        private static int GetType(char symbol)
        {
            var result = 0;

            if (symbol == 'S')
            {
                result = 4;
            }
            else if (symbol == 'H')
            {
                result = 3;
            }
            else if (symbol == 'D')
            {
                result = 2;
            }
            else if (symbol == 'C')
            {
                result = 1;
            }

            return result;
        }
    }
}