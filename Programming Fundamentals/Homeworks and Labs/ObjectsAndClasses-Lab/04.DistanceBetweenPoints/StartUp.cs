namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var pointOne = ReadPoint();
            var pointTwo = ReadPoint();

            var distance = CalcDistance(pointOne, pointTwo);

            Console.WriteLine("Distance: {0:f3}", distance);
        }

        private static Point ReadPoint()
        {
            var pointCordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var point = new Point();
            point.X = pointCordinates[0];
            point.Y = pointCordinates[1];

            return point;
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            var deltaX = p2.X - p1.X;
            var deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}