namespace _11.USDToBGN
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;

            Console.WriteLine("{0:f2}", bgn);
        }
    }
}