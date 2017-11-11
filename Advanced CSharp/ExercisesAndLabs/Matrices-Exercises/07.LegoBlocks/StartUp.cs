namespace _07.LegoBlocks
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var first = new string[n][];
            var second = new string[n][];

            for (int i = 0; i < n; i++)
            {
                first[i] = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < n; i++)
            {
                second[i] = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var reversed = new string[n][];

            for (int i = 0; i < second.Length; i++)
            {
                reversed[i] = new string[second[i].Length];
                reversed[i] = second[i].Reverse().ToArray();
            }

            var firstRowLength = first[0].Length + reversed[0].Length;
            var areFit = true;

            for (int i = 1; i < n; i++)
            {
                if (first[i].Length + reversed[i].Length != firstRowLength)
                {
                    areFit = false;
                    break;
                }
            }

            var result = new string[n][];

            for (int i = 0; i < n; i++)
            {
                result[i] = new string[firstRowLength];
            }

            if (areFit)
            {
                var counter = 0;

                for (int i = 0; i < n; i++)
                {
                    counter = 0;

                    for (int j = 0; j < first[i].Length; j++)
                    {
                        result[i][counter] = first[i][j];
                        counter++;
                    }

                    for (int j = 0; j < reversed[i].Length; j++)
                    {
                        result[i][counter] = reversed[i][j];
                        counter++;
                    }
                }

                foreach (var row in result)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
            else
            {
                var numberOfCells = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < first[i].Length; j++)
                    {
                        numberOfCells++;
                    }
                    for (int j = 0; j < second[i].Length; j++)
                    {
                        numberOfCells++;
                    }
                }

                Console.WriteLine($"The total number of cells is: {numberOfCells}");
            }
        }
    }
}