namespace _07.Greeting
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string ageStr = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {ageStr} years old.");
        }
    }
}