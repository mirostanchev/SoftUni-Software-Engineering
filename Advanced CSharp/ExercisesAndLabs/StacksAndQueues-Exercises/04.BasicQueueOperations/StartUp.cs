namespace _04.BasicQueueOperations
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
            var queue = new Queue<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                queue.Dequeue();
            }

            var count = queue.Count;

            if (count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var min = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                var num = queue.Dequeue();

                if (num == seekedNum)
                {
                    Console.WriteLine("true");
                    return;
                }

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}