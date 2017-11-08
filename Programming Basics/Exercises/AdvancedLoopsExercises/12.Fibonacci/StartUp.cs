namespace _12.Fibonacci
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var fibOne = 1;
            var fibTwo = 1;

            for (int i = 0; i < num - 1; i++)
            {
                var fibNext = fibOne + fibTwo;
                fibOne = fibTwo;
                fibTwo = fibNext;
            }

            Console.WriteLine(fibTwo);
        }
    }
}