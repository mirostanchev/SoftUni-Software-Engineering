namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var secondInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstCenter = new Point { X = firstInfo[0], Y = firstInfo[1] };
            var firstRadius = firstInfo[2];
            var firstCicle = new Circle { Center = firstCenter, Radius = firstRadius };

            var secondCenter = new Point { X = secondInfo[0], Y = secondInfo[1] };
            var secondRadius = secondInfo[2];
            var secondCircle = new Circle { Center = secondCenter, Radius = secondRadius };

            var result = Intersect(firstCicle, secondCircle);

            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool Intersect(Circle first, Circle second)
        {
            var intersect = false;
            var distance =
                Math.Sqrt(Math.Pow(first.Center.X - second.Center.X, 2) + Math.Pow(first.Center.Y - second.Center.Y, 2));

            if (distance <= first.Radius + second.Radius)
            {
                intersect = true;
            }

            return intersect;
        }
    }
}