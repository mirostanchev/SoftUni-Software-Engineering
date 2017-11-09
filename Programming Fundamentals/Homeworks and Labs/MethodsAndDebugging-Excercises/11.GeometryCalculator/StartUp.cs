namespace _11.GeometryCalculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var typeFigure = Console.ReadLine();

            if (typeFigure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", GetTriangleArea(side, height));
            }
            else if (typeFigure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetSquareArea(side));
            }
            else if (typeFigure == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", GetRectangleArea(width, height));
            }
            else
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetCircleArea(radius));
            }
        }

        private static double GetTriangleArea(double side, double height)
        {
            var area = (side * height) / 2;
            return area;
        }

        private static double GetSquareArea(double side)
        {
            var area = Math.Pow(side, 2);
            return area;
        }

        private static double GetRectangleArea(double width, double height)
        {
            var area = width * height;
            return area;
        }

        private static double GetCircleArea(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
    }
}