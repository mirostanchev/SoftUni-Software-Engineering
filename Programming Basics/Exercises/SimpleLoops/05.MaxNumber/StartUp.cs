namespace _05.MaxNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var counter = int.Parse(Console.ReadLine());
            var max = int.MinValue;

            for (int i = 0; i < counter; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

            Console.WriteLine(max);
        }
    }
}