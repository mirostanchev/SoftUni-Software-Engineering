namespace _01.ReverseNumbers
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split();
            var stack = new Stack<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                stack.Push(nums[i]);
            }

            var count = stack.Count;

            for (int i = 0; i < count; i++)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}