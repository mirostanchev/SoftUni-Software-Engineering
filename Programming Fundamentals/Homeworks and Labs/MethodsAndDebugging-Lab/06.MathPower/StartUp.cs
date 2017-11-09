namespace _06.MathPower
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcNumber(number, power));
        }

        private static double CalcNumber(double num, int pow)
        {
            var result = Math.Pow(num, pow);
            return result;
        }
    }
}