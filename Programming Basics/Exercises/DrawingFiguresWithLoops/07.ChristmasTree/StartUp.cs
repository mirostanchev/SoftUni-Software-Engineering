namespace _07.ChristmasTree
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var spaces = num - 1;
            var asterix = 1;

            for (int i = 1; i <= num + 1; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0} | {0}", new string(' ', num));
                }
                else
                {
                    Console.WriteLine("{0}{1} | {1}{0}", new string(' ', spaces), new string('*', asterix));

                    spaces--;
                    asterix++;
                }
            }
        }
    }
}