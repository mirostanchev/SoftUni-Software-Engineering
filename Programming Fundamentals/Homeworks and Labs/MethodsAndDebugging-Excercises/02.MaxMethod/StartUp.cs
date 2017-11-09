namespace _02.MaxMethod
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, b, c));
        }

        private static int GetMax(int a, int b, int c)
        {
            var max = int.MinValue;

            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (b >= a && b >= c)
            {
                max = b;
            }
            else if (c >= a && c >= b)
            {
                max = c;
            }

            return max;
        }
    }
}