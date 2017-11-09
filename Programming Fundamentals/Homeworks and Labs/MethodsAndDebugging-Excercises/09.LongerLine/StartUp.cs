namespace _09.LongerLine
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
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var line1 = GetLongerLine(x1, y1, x2, y2);
            var line2 = GetLongerLine(x3, y3, x4, y4);

            if (line1 >= line2)
            {
                var isFirstCloser = CloserPoint(x1, y1, x2, y2);

                if (isFirstCloser)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
            }
            else
            {
                var isFirstCloser = CloserPoint(x3, y3, x4, y4);

                if (isFirstCloser)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
            }
        }

        private static double GetLongerLine(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return distance;
        }

        private static bool CloserPoint(double x1, double y1, double x2, double y2)
        {
            var c1 = Math.Sqrt(x1 * x1 + y1 * y1);
            var c2 = Math.Sqrt(x2 * x2 + y2 * y2);
            var closerOrNot = true;

            if (c1 < c2)
            {
                closerOrNot = true;
            }
            else if (c1 > c2)
            {
                closerOrNot = false;
            }

            return closerOrNot;
        }
    }
}