namespace _02.SquareWithMaximumSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var maxtrixInfo = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = maxtrixInfo[0];
            var cols = maxtrixInfo[1];
            var matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var index = 0;
                var currentNums = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentNums[index];
                    index++;
                }
            }

            var maxSum = int.MinValue;
            var maxR = 0;
            var maxC = 0;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    var currentSum = matrix[r, c] + matrix[r + 1, c] + matrix[r, c + 1] + matrix[r + 1, c + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxC = c;
                        maxR = r;
                    }
                }
            }

            for (int i = maxR; i <= maxR + 1; i++)
            {
                for (int j = maxC; j <= maxC + 1; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}