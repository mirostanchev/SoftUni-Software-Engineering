namespace _05.Sequence2k_1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}