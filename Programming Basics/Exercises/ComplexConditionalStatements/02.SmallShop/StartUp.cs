namespace _02.SmallShop
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var price = 0d;

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50;
                }
                else if (product == "water")
                {
                    price = 0.80;
                }
                else if (product == "beer")
                {
                    price = 1.20;
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                }
                else
                {
                    price = 1.60;
                }
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                }
                else
                {
                    price = 1.50;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    price = 0.45;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.10;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else
                {
                    price = 1.55;
                }
            }

            Console.WriteLine(price * quantity);
        }
    }
}