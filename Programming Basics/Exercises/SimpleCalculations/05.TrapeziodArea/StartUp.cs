namespace _05.TrapeziodArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid area = {0}", area);
        }
    }
}