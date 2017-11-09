namespace _08.CenterPoint
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var firstDistance = GetDistance(x1, y1);
            var secondDistance = GetDistance(x2, y2);

            if (firstDistance <= secondDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double GetDistance(double x, double y)
        {
            var distance = Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}