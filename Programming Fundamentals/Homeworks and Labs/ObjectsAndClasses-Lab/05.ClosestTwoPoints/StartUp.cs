namespace _05.ClosestTwoPoints
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var points = ReadPoints();
            var closestPoint = FindClosestTwoPoints(points);

            PrintDistance(closestPoint);
            PrintPoint(closestPoint[0]);
            PrintPoint(closestPoint[1]);
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

        private static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            var deltaX = p2.X - p1.X;
            var deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private static void PrintDistance(Point[] points)
        {
            var distance = CalcDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    var distance = CalcDistance(points[p1], points[p2]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            }

            return closestTwoPoints;
        }
    }
}