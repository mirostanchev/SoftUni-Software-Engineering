namespace _07.ExchangeVariableValues
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Before:");
            Console.WriteLine("a = " + temp);
            Console.WriteLine("b = " + a);
            Console.WriteLine("After:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + temp);
        }
    }
}