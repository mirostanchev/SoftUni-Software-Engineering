﻿namespace _07.TwoDRectangleArea
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

            var sideA = Math.Max(x1, x2) - Math.Min(x1, x2);
            var sideB = Math.Max(y1, y2) - Math.Min(y1, y2);

            var area = sideA * sideB;
            var perimeter = 2 * sideA + 2 * sideB;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}