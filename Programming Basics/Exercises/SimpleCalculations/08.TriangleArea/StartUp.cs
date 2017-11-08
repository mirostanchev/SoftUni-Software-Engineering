namespace _08.TriangleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = side * h / 2;
            Console.WriteLine("Triangle area = {0:f2}", area);
        }
    }
}