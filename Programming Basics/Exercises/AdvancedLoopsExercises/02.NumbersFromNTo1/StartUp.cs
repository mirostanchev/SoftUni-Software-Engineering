namespace _02.NumbersFromNTo1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}