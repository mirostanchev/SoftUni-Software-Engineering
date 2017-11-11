namespace _04.MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var expression = Console.ReadLine();
            var opening = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    opening.Push(i);
                }
                else if (expression[i] == ')')
                {
                    var startIndex = opening.Pop();
                    var subsStr = expression.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(subsStr);
                }
            }
        }
    }
}