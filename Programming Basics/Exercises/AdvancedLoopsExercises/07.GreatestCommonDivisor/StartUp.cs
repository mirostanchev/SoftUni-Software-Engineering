namespace _07.GreatestCommonDivisor
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var greater = Math.Max(a, b);
            var smaller = Math.Min(a, b);

            while (smaller != 0)
            {
                var newNum = greater % smaller;
                greater = smaller;
                smaller = newNum;
            }

            Console.WriteLine(greater);
        }
    }
}