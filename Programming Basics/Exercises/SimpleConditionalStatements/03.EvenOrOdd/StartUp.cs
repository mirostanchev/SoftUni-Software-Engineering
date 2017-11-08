namespace _03.EvenOrOdd
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}