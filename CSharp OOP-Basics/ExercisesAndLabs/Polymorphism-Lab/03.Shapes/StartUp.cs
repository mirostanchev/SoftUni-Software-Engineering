namespace _03.Shapes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Shape circle = new Circle(5);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
        }
    }
}