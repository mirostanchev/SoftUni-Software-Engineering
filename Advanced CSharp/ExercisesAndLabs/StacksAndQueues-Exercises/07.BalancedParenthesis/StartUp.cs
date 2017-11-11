namespace _07.BalancedParenthesis
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var opening = new Stack<char>();
            var areBalanced = true;

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (inputLine[i] == '(' || inputLine[i] == '[' || inputLine[i] == '{')
                {
                    opening.Push(inputLine[i]);
                }

                if (opening.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }

                if (inputLine[i] == ')')
                {
                    if (opening.Peek() == '(')
                    {
                        opening.Pop();
                    }
                    else
                    {
                        areBalanced = false;
                        break;
                    }
                }
                else if (inputLine[i] == ']')
                {
                    if (opening.Peek() == '[')
                    {
                        opening.Pop();
                    }
                    else
                    {
                        areBalanced = false;
                        break;
                    }
                }
                else if (inputLine[i] == '}')
                {
                    if (opening.Peek() == '{')
                    {
                        opening.Pop();
                    }
                    else
                    {
                        areBalanced = false;
                        break;
                    }
                }
            }

            Console.WriteLine(areBalanced ? "YES" : "NO");
        }
    }
}