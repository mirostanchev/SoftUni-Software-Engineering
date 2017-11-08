﻿namespace _06.PointOnRectangleBorder
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool topSide = (y == y1 && x >= x1 && x <= x2);
            bool downSide = (y == y2 && x >= x1 && x <= x2);
            bool leftSide = (x == x1 && y >= y1 && y <= y2);
            bool rightSide = (x == x2 && y >= y1 && y <= y2);

            if (topSide || downSide || leftSide || rightSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}