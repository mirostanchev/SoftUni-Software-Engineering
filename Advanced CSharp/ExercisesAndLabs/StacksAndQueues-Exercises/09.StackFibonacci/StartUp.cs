namespace _09.StackFibonacci
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var fibNums = new Stack<long>();

            fibNums.Push(0);
            fibNums.Push(1);

            for (int i = 1; i < n; i++)
            {
                var last = fibNums.Peek();
                var next = fibNums.Pop() + fibNums.Pop();

                fibNums.Push(last);
                fibNums.Push(next);
            }

            Console.WriteLine(fibNums.Peek());
        }
    }
}