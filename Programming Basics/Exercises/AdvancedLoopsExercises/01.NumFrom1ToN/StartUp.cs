namespace _01.NumFrom1ToN
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}