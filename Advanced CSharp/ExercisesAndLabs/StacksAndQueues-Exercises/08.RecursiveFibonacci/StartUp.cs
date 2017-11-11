namespace _08.RecursiveFibonacci
{
    using System;

    public class StartUp
    {
        public static long[] fibNums;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            fibNums = new long[n];

            var result = GetFib(n);
            Console.WriteLine(result);
        }

        private static long GetFib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            if (fibNums[n - 1] != 0)
            {
                return fibNums[n - 1];
            }

            return fibNums[n - 1] = GetFib(n - 1) + GetFib(n - 2);
        }
    }
}