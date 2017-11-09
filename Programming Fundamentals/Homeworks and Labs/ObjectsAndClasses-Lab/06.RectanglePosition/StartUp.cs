namespace _06.RectanglePosition
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstRectangle = new Rectangle
            {
                X1 = first[0], Y1 = first[1], X2 = first[0] + first[2], Y2 = first[1] + first[3]
            };
            var secondRectangle = new Rectangle
            {
                X1 = second[0], Y1 = second[1], X2 = second[0] + second[2], Y2 = second[1] + second[3]
            };

            var result = IsInside(firstRectangle, secondRectangle);

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static bool IsInside(Rectangle first, Rectangle second)
        {
            var isInside = false;

            var left = first.X1 >= second.X1;
            var right = first.X2 <= second.X2;
            var top = first.Y1 >= second.Y1;
            var bottom = first.Y2 <= second.Y2;

            if (left && right && top && bottom)
            {
                isInside = true;
            }

            return isInside;
        }
    }
}