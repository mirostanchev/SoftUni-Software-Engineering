namespace _03.SquareOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.Write("*");

                for (int j = 1; j < count; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}