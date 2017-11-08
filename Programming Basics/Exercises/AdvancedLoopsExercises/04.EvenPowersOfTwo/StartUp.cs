namespace _04.EvenPowersOfTwo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 1;

            for (int i = 1; i <= num + 1; i += 2)
            {
                Console.WriteLine(sum);
                sum *= 4;
            }
        }
    }
}