namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}