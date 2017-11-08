namespace _06.CircleAreaAndPerimeter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}