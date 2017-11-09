namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arrOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var arrTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var length = Math.Max(arrOne.Length, arrTwo.Length);
            var sum = new int[length];

            for (int i = 0; i < length; i++)
            {
                sum[i] = arrOne[i % arrOne.Length] + arrTwo[i % arrTwo.Length];
                Console.Write(sum[i] + " ");
            }

            Console.WriteLine();
        }
    }
}