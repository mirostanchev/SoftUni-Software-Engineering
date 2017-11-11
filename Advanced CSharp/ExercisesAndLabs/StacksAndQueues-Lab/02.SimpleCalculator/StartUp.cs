namespace _02.SimpleCalculator
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var expression = Console.ReadLine().Split();
            var stack = new Stack<string>();
            var result = 0;

            for (int i = expression.Length - 1; i >= 0; i--)
            {
                stack.Push(expression[i]);
            }

            var count = stack.Count;

            var firstNum = int.Parse(stack.Pop());

            for (int i = 1; i < count - 1; i += 2)
            {
                var @operator = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                if (@operator == "+")
                {
                    result = firstNum + secondNum;
                }
                else
                {
                    result = firstNum - secondNum;
                }

                firstNum = result;
            }

            Console.WriteLine(result);
        }
    }
}