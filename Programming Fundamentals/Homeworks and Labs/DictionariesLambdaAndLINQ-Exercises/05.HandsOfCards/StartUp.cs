namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var peopleScore = new Dictionary<string, List<string>>();

            while (!inputLine.Equals("JOKER"))
            {
                var lineArgs = inputLine.Split(':').ToArray();
                var personName = lineArgs[0].Trim();

                var cards = lineArgs[1]
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!peopleScore.ContainsKey(personName))
                {
                    peopleScore.Add(personName, new List<string>());
                }

                peopleScore[personName].AddRange(cards);

                inputLine = Console.ReadLine();
            }

            foreach (var score in peopleScore)
            {
                var peopleHands = score.Value.Distinct().ToList();
                var value = GetValue(peopleHands);

                Console.WriteLine($"{score.Key}: {value}");
            }
        }

        private static int GetValue(List<string> cards)
        {
            var value = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                var faceCardpower = GetFaceCardPower(cards[i].Substring(0, cards[i].Length - 1));
                var suitPower = GetSuitPower(cards[i].Substring(cards[i].Length - 1));

                value += faceCardpower * suitPower;
            }

            return value;
        }

        private static int GetFaceCardPower(string faceCard)
        {
            try
            {
                return int.Parse(faceCard);
            }
            catch (Exception)
            {
                switch (faceCard)
                {
                    case "J":
                        return 11;
                    case "Q":
                        return 12;
                    case "K":
                        return 13;
                    case "A":
                        return 14;
                    default:
                        return 0;
                }
            }
        }

        private static int GetSuitPower(string suit)
        {
            switch (suit)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}