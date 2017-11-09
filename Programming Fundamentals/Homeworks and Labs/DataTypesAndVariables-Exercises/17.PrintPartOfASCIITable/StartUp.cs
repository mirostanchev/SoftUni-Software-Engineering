namespace _17.PrintPartOfASCIITable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write((char)(i) + " ");
            }

            Console.WriteLine();
        }
    }
}