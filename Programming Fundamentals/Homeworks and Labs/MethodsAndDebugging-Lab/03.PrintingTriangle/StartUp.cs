namespace _03.PrintingTriangle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintTriangle(num);
        }

        private static void PrintTriangle(int num)
        {
            PrintHeader(num);
            PrintFooter(num);
        }
        private static void PrintHeader(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
        private static void PrintFooter(int num)
        {
            for (int i = num - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}