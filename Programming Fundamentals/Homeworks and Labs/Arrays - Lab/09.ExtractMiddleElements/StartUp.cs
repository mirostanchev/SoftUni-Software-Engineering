namespace _09.ExtractMiddleElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int length = numbers.Length;

            if (length == 1)
            {
                Console.WriteLine("{ " + numbers[0] + " }");
            }
            else if (length % 2 == 0)
            {
                Console.Write("{");
                Console.Write(" {0}, {1} ", numbers[length / 2 - 1], numbers[length / 2]);
                Console.WriteLine("}");
            }
            else
            {
                Console.Write("{");
                Console.Write("{0}, {1}, {2}", numbers[length / 2 - 1], numbers[length / 2], numbers[length / 2 + 1]);
                Console.WriteLine("}");
            }
        }
    }
}