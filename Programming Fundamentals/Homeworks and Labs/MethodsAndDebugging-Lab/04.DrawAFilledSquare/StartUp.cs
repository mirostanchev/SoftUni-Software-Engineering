namespace _04.DrawAFilledSquare
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintFirstLastRow(num);

            for (int i = 0; i < num - 2; i++)
            {
                PrintMiddleRow(num);
            }

            PrintFirstLastRow(num);
        }

        private static void PrintFirstLastRow(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }

        private static void PrintMiddleRow(int num)
        {
            Console.Write("-");

            for (int i = 1; i < num; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }
}