namespace _09.ReversedChars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            Console.WriteLine($"{third}{second}{first}");
        }
    }
}