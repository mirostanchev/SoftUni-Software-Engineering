namespace _02.DiagonalDifference
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var matrixSize = int.Parse(Console.ReadLine().Trim());
            var matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                var nums = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = nums[j];
                }
            }

            var primaryDiagonal = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                primaryDiagonal += matrix[i, i];
            }

            var secondaryDiagonal = 0;
            var row = 0;
            var col = matrixSize - 1;

            for (int i = 0; i < matrixSize; i++)
            {
                secondaryDiagonal += matrix[row, col];
                row++;
                col--;
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}