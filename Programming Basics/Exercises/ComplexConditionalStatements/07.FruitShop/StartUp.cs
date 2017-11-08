namespace _07.FruitShop
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var price = 0d;

            if (fruit == "banana")
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 2.50;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else if (day == "saturday" || day == "sunday")
                {
                    price = 2.70;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "apple")
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 1.20;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else if (day == "saturday" || day == "sunday")
                {
                    price = 1.25;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "orange")
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 0.85;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else if (day == "saturday" || day == "sunday")
                {
                    price = 0.90;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapefruit")
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 1.45;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else if (day == "saturday" || day == "sunday")
                {
                    price = 1.60;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "kiwi")
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 2.70;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else if (day == "saturday" || day == "sunday")
                {
                    price = 3.00;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "pineapple")
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 5.50;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else if (day == "saturday" || day == "sunday")
                {
                    price = 5.60;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapes")
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 3.85;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else if (day == "saturday" || day == "sunday")
                {
                    price = 4.20;
                    Console.WriteLine("{0:f2}", price * quantity);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}