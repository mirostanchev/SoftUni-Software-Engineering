namespace _06.NumberInRange_1._._._100_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number in the range [1...100]: ");
                var number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 100)
                {
                    Console.WriteLine("The number is: {0}", number);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}