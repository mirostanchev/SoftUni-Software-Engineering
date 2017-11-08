namespace _13.AreaOfFigures
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var figureType = Console.ReadLine().ToLower();

            if (figureType == "square")
            {
                var side = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(side * side, 3));
            }

            else if (figureType == "rectangle")
            {
                var sideA = double.Parse(Console.ReadLine());
                var sideB = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(sideA * sideB, 3));
            }
            else if (figureType == "circle")
            {
                var radius = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(Math.PI * radius * radius, 3));
            }
            else
            {
                var sideA = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(sideA * height / 2, 3));
            }
        }
    }
}