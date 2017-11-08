namespace _06.SquareOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.WriteLine(new string('*', n));
                }
                else
                {
                    Console.WriteLine("*{0}*", new string(' ', n - 2));
                }
            }
        }
    }
}