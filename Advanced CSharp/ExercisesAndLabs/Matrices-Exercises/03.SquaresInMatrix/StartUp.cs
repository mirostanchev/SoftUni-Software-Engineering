namespace _03.SquaresInMatrix
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
            var matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var letters = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = letters[j];
                }
            }

            var counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] 
                        && matrix[row, col + 1] == matrix[row + 1, col] 
                        && matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}