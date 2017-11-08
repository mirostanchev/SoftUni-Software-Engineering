namespace _04.TriangleOfDollars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("$");

                for (int j = 1; j < i; j++)
                {
                    Console.Write(" $");
                }

                Console.WriteLine();
            }
        }
    }
}