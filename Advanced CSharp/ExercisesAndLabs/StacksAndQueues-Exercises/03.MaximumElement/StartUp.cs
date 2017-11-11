namespace _03.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new Stack<int>();
            var maxNums = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    var num = command[1];
                    elements.Push(num);

                    if (maxNums.Count == 0 || num > maxNums.Peek())
                    {
                        maxNums.Push(num);
                    }
                }
                else if (command[0] == 2)
                {
                    var num = elements.Pop();

                    if (maxNums.Peek() == num)
                    {
                        maxNums.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    Console.WriteLine(maxNums.Peek());
                }
            }
        }
    }
}