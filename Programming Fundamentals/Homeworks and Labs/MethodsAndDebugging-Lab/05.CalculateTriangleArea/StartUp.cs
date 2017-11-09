namespace _05.CalculateTriangleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = GetTriangleArea(width, height);

            Console.WriteLine(area);
        }

        private static double GetTriangleArea(double width, double height)
        {
            var area = width * height / 2;
            return area;
        }
    }
}