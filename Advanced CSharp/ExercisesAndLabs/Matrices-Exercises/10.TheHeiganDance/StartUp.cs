namespace _10.TheHeiganDance
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var playerRow = 7;
            var playerCol = 7;
            var playerHP = 18500;
            var heiganHP = 3000000d;

            var playerDamage = double.Parse(Console.ReadLine());
            var lastSpell = "";

            while (true)
            {
                if (playerHP >= 0)
                {
                    heiganHP -= playerDamage;
                }
                if (lastSpell.Equals("Cloud"))
                {
                    playerHP -= 3500;
                }
                if (heiganHP <= 0 || playerHP <= 0)
                {
                    break;
                }

                var input = Console.ReadLine().Split();
                var currentSpell = input[0];
                var targetRow = int.Parse(input[1]);
                var targetCol = int.Parse(input[2]);

                if (isInDamageArea(targetRow, targetCol, playerRow, playerCol))
                {
                    if (!isInDamageArea(targetRow, targetCol, playerRow - 1, playerCol) && !isWall(playerRow - 1))
                    {
                        playerRow--;
                        lastSpell = "";
                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow, playerCol + 1) && !isWall(playerCol + 1))
                    {
                        playerCol++;
                        lastSpell = "";
                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow + 1, playerCol) && !isWall(playerRow + 1))
                    {
                        playerRow++;
                        lastSpell = "";
                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow, playerCol - 1) && !isWall(playerCol - 1))
                    {
                        playerCol--;
                        lastSpell = "";
                    }
                    else
                    {
                        if (currentSpell.Equals("Cloud"))
                        {
                            playerHP -= 3500;
                            lastSpell = "Cloud";
                        }
                        else if (currentSpell.Equals("Eruption"))
                        {
                            playerHP -= 6000;
                            lastSpell = "Eruption";
                        }
                    }
                }
            }

            lastSpell = lastSpell.Equals("Cloud") ? "Plague Cloud" : "Eruption";

            var heiganState = heiganHP <= 0 ? "Heigan: Defeated!" : string.Format("Heigan: {0:f2}", heiganHP);
            var playerState = playerHP <= 0 ? string.Format("Player: Killed by {0}", lastSpell) :
                string.Format("Player: {0}", playerHP);
            var playerEndCoordinates = string.Format("Final position: {0}, {1}", playerRow, playerCol);

            Console.WriteLine(heiganState);
            Console.WriteLine(playerState);
            Console.WriteLine(playerEndCoordinates);
        }

        private static bool isWall(int moveCell)
        {
            return moveCell < 0 || moveCell >= 15;
        }

        private static bool isInDamageArea(int targetRow, int targetCol, int moveRow, int moveCol)
        {
            return ((targetRow - 1 <= moveRow && moveRow <= targetRow + 1)
                    && (targetCol - 1 <= moveCol && moveCol <= targetCol + 1));
        }
    }
}