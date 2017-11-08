namespace _04.SumNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var counter = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < counter; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}