namespace _03.DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var decimalNum = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            do
            {
                var remainder = decimalNum % 2;
                decimalNum /= 2;

                stack.Push(remainder);
            } while (decimalNum > 0);


            var count = stack.Count;

            for (int i = 0; i < count; i++)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}