namespace _01.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            var count = stack.Count;

            for (int i = 0; i < count; i++)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}