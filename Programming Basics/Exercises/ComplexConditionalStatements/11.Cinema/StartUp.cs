namespace _11.Cinema
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var typeProjection = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());

            var priceProjection = 0d;

            if (typeProjection == "premiere")
            {
                priceProjection = 12.00;
            }
            else if (typeProjection == "normal")
            {
                priceProjection = 7.50;
            }
            else
            {
                priceProjection = 5.00; ;
            }

            Console.WriteLine("{0:f2} leva", priceProjection * col * row);
        }
    }
}