namespace _02.RectangleOfNxNStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(new string('*', count));
            }
        }
    }
}