namespace _09.SumDigits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            while (num > 0)
            {
                sum = sum + (num % 10);
                num = num / 10;
            }

            Console.WriteLine(sum);
        }
    }
}