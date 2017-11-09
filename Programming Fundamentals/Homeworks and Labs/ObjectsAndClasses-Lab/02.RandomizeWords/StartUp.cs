namespace _02.RandomizeWords
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var second = rnd.Next(0, input.Length);
                var old = input[i];
                input[i] = input[second];
                input[second] = old;
            }

            Console.WriteLine(string.Join("\r\n", input));
        }
    }
}