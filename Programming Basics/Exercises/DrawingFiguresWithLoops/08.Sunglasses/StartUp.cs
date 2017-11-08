namespace _08.Sunglasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * num), new string(' ', num));

            for (int i = 1; i <= num - 2; i++)
            {
                if (i == (num - 1) / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * num) - 2), new string('|', num));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * num) - 2), new string(' ', num));
                }
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * num), new string(' ', num));
        }
    }
}