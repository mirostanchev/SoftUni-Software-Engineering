namespace _16.ComparingFloats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            const double epsilon = 0.000001;
            double diff = Math.Abs(firstNum - secondNum);

            if (diff > epsilon)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}