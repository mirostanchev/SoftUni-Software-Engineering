namespace _04.GreaterNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var numberOne = double.Parse(Console.ReadLine());
            var numberTwo = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }
        }
    }
}