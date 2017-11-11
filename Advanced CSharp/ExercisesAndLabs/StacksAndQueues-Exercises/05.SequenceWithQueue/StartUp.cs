namespace _05.SequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            var elements = new Queue<long>();
            elements.Enqueue(n);
            var result = new List<long>();
            result.Add(n);

            while (result.Count < 50)
            {
                var currentElement = elements.Dequeue();
                var firstNum = currentElement + 1;
                var secondNum = (currentElement * 2) + 1;
                var thirdNum = currentElement + 2;

                elements.Enqueue(firstNum);
                elements.Enqueue(secondNum);
                elements.Enqueue(thirdNum);

                result.Add(firstNum);
                result.Add(secondNum);
                result.Add(thirdNum);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }
    }
}