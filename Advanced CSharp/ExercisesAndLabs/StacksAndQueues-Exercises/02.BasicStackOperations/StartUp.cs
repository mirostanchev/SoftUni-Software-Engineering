namespace _02.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numbersToPush = numsInfo[0];
            var numbersToPop = numsInfo[1];
            var seekedNum = numsInfo[2];
            var stack = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            var min = int.MaxValue;
            var count = stack.Count;

            if (count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < count; i++)
            {
                var currentNum = stack.Pop();

                if (currentNum == seekedNum)
                {
                    Console.WriteLine("true");
                    return;
                }

                if (currentNum < min)
                {
                    min = currentNum;
                }
            }

            Console.WriteLine(min);
        }
    }
}