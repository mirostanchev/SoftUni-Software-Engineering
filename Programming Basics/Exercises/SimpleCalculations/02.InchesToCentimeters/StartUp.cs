namespace _02.InchesToCentimeters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var inches = double.Parse(Console.ReadLine());

            Console.WriteLine(inches * 2.54);
        }
    }
}