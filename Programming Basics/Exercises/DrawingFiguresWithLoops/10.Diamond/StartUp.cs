namespace _10.Diamond
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                var dashesCounter = (num - 2) / 2;
                var middleDashes = 0;

                for (int i = 1; i <= num / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', dashesCounter), new string('-', middleDashes));

                    middleDashes += 2;
                    dashesCounter--;
                }

                dashesCounter = 1;
                middleDashes = num - 4;

                for (int i = 1; i <= (num / 2) - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', dashesCounter), new string('-', middleDashes));

                    dashesCounter++;
                    middleDashes -= 2;
                }
            }
            else
            {
                var dashes = (num - 1) / 2;
                Console.WriteLine("{0}*{0}", new string('-', dashes));

                var outsideDashes = (num - 3) / 2;
                var middleDashes = 1;

                for (int i = 0; i < num / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', outsideDashes), new string('-', middleDashes));

                    outsideDashes--;
                    middleDashes += 2;
                }

                outsideDashes = 1;
                middleDashes = num - 4;

                for (int i = 1; i < num / 2; i++)
                {

                    Console.WriteLine("{0}*{1}*{0}", new string('-', outsideDashes), new string('-', middleDashes));
                    outsideDashes++;
                    middleDashes -= 2;
                }

                if (num != 1)
                {
                    Console.WriteLine("{0}*{0}", new string('-', dashes));
                }
            }
        }
    }
}