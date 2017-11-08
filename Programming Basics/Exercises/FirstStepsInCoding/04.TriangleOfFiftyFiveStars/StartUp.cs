namespace _04.TriangleOfFiftyFiveStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}