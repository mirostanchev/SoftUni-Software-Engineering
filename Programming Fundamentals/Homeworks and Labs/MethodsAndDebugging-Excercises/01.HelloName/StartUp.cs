namespace _01.HelloName
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}