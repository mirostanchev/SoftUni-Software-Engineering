namespace _03.SeriesOfNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(.)\1+");

            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}