namespace _09.IndexOfLetters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", input[i], input[i] - 97);
            }
        }
    }
}