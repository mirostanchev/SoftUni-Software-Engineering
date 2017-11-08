namespace _06.MinNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var counter = int.Parse(Console.ReadLine());
            var min = int.MaxValue;

            for (int i = 0; i < counter; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < min)
                {
                    min = currentNumber;
                }
            }

            Console.WriteLine(min);
        }
    }
}