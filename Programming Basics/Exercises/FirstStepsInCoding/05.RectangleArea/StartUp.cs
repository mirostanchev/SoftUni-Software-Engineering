namespace _05.RectangleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());

            var area = a * b;
            Console.WriteLine(area);
        }
    }
}