namespace _08.TradeComissions
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());

            var comission = 0d;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.08;
                }
                else if (sales > 10000)
                {
                    comission = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.10;
                }
                else if (sales > 10000)
                {
                    comission = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.12;
                }
                else if (sales > 10000)
                {
                    comission = 0.145;
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

            Console.WriteLine("{0:f2}", sales * comission);
        }
    }
}