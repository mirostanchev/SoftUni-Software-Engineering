namespace _08.Factorial
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var fact = 1;

            while (num > 1)
            {
                fact = fact * num;
                num--;
            }

            Console.WriteLine(fact);
        }
    }
}