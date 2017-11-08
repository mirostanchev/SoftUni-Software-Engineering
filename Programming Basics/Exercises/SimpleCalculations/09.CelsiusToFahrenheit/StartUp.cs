namespace _09.CelsiusToFahrenheit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var celsuis = double.Parse(Console.ReadLine());
            var fahrenheit = (celsuis * 1.8) + 32;

            Console.WriteLine("{0:f2}", fahrenheit);
        }
    }
}