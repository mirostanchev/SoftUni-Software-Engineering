namespace _05.CompareCharArrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arrOne = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
            var arrTwo = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            var length = Math.Min(arrOne.Length, arrTwo.Length);
            var areDiff = false;

            for (int i = 0; i < length; i++)
            {
                if (arrOne[i] > arrTwo[i])
                {
                    Console.WriteLine(string.Join("", arrTwo));
                    Console.WriteLine(string.Join("", arrOne));
                    areDiff = true;
                    break;
                }
                else if (arrTwo[i] > arrOne[i])
                {
                    Console.WriteLine(string.Join("", arrOne));
                    Console.WriteLine(string.Join("", arrTwo));
                    areDiff = true;
                    break;
                }
            }

            if (!areDiff)
            {
                if (arrOne.Length > arrTwo.Length)
                {
                    Console.WriteLine(string.Join("", arrTwo));
                    Console.WriteLine(string.Join("", arrOne));
                }
                else
                {
                    Console.WriteLine(string.Join("", arrOne));
                    Console.WriteLine(string.Join("", arrTwo));
                }
            }
        }
    }
}