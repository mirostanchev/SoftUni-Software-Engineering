namespace _04.MaximalSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var matrixInfo = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rows = matrixInfo[0];
            var cols = matrixInfo[1];
            var matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var nums = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = nums[j];
                }
            }

            var maxRowIndex = 0;
            var maxColIndex = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                                     matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                                     matrix[row + 2, col + 1] +
                                     matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRowIndex; row <= maxRowIndex + 2; row++)
            {
                for (int col = maxColIndex; col <= maxColIndex + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}