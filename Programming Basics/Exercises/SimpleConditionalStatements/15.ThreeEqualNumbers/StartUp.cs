namespace _15.ThreeEqualNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}