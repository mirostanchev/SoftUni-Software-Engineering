namespace _13.PointInTheFigure
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var firstRectangle = (x > h && x < 2 * h && y >= h && y < 4 * h);
            var secondRectangle = (x > 0 && x < 3 * h && y > 0 && y < h);

            var firstTop = (y == 4 * h && x >= h && x <= 2 * h);
            var firstLeft = (x == h && y >= h && y <= 4 * h);
            var firstRight = (x == 2 * h && y >= h && y <= 4 * h);
            var secondUpLeft = (y == h && x >= 0 && x <= h);
            var secondUpRight = (y == h && x >= 2 * h && x <= 3 * h);
            var secondLeft = (x == 0 && y >= 0 && y <= h);
            var secondRight = (x == 3 * h && y >= 0 && y <= h);
            var secondDown = (y == 0 && x >= 0 && x <= 3 * h);
            
            if (firstRectangle || secondRectangle)
            {
                Console.WriteLine("inside");
            }
            else if (firstTop || firstLeft || firstRight || secondUpLeft || secondUpRight || secondLeft || secondRight || secondDown)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}