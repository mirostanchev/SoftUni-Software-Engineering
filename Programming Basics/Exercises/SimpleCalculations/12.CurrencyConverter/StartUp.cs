namespace _12.CurrencyConverter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var value = double.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToUpper();
            var output = Console.ReadLine().ToUpper();

            var sum = 0d;

            if (input == "BGN")
            {
                if (output == "USD")
                {
                    sum = value / 1.79549;
                    Console.WriteLine("{0:f2} USD", sum);
                }
                else if (output == "EUR")
                {
                    sum = value / 1.95583;
                    Console.WriteLine("{0:f2} EUR", sum);
                }
                else
                {
                    sum = value / 2.53405;
                    Console.WriteLine("{0:f2} GBP", sum);
                }
            }
            else if (input == "USD")
            {
                if (output == "BGN")
                {
                    sum = value * 1.79549;
                    Console.WriteLine("{0:f2} BGN", sum);
                }
                else if (output == "EUR")
                {
                    sum = (value * 1.79549) / 1.95583;
                    Console.WriteLine("{0:f2} EUR", sum);
                }
                else
                {
                    sum = (value * 1.79549) / 2.53405;
                    Console.WriteLine("{0:f2} GBP", sum);
                }
            }
            else if (input == "EUR")
            {
                if (output == "BGN")
                {
                    sum = value * 1.95583;
                    Console.WriteLine("{0:f2} BGN", sum);
                }
                else if (output == "USD")
                {
                    sum = (value * 1.95583) / 1.79549;
                    Console.WriteLine("{0:f2} USD", sum);
                }
                else
                {
                    sum = (value * 1.95583) / 2.53405;
                    Console.WriteLine("{0:f2} GBP", sum);
                }
            }
            else
            {
                if (output == "BGN")
                {
                    sum = value * 2.53405;
                    Console.WriteLine("{0:f2} BGN", sum);
                }
                else if (output == "USD")
                {
                    sum = (value * 2.53405) / 1.79549;
                    Console.WriteLine("{0:f2} USD", sum);
                }
                else
                {
                    sum = (value * 2.53405) / 1.95584;
                    Console.WriteLine("{0:f2} EUR", sum);
                }
            }
        }
    }
}