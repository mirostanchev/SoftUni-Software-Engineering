namespace _05.RubiksMatrix
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var matrixInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rows = matrixInfo[0];
            var cols = matrixInfo[1];
            var matrix = new int[rows, cols];
            var numberOfCommands = int.Parse(Console.ReadLine());

            var counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandArgs = Console.ReadLine().Split();
                var direction = commandArgs[1];
                var moves = int.Parse(commandArgs[2]);
                int rowIndex;
                int colIndex;

                if (direction == "right")
                {
                    rowIndex = int.Parse(commandArgs[0]);
                    MoveRight(matrix, rowIndex, moves);
                }
                else if (direction == "left")
                {
                    rowIndex = int.Parse(commandArgs[0]);
                    MoveLeft(matrix, rowIndex, moves);
                }
                else if (direction == "up")
                {
                    colIndex = int.Parse(commandArgs[0]);
                    MoveUp(matrix, colIndex, moves);
                }
                else if (direction == "down")
                {
                    colIndex = int.Parse(commandArgs[0]);
                    MoveDown(matrix, colIndex, moves);
                }
            }

            counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        var searchedRow = 0;
                        var searchedCol = 0;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == counter)
                                {
                                    searchedRow = i;
                                    searchedCol = j;
                                }
                            }
                        }

                        var temp = matrix[row, col];
                        matrix[row, col] = matrix[searchedRow, searchedCol];
                        matrix[searchedRow, searchedCol] = temp;

                        Console.WriteLine($"Swap ({row}, {col}) with ({searchedRow}, {searchedCol})");
                    }
                    counter++;
                }
            }
        }

        private static void MoveDown(int[,] matrix, int colIndex, int moves)
        {
            for (int i = 0; i < moves % matrix.GetLength(0); i++)
            {
                var lastElement = matrix[matrix.GetLength(0) - 1, colIndex];

                for (int row = matrix.GetLength(0) - 1; row >= 1; row--)
                {
                    matrix[row, colIndex] = matrix[row - 1, colIndex];
                }

                matrix[0, colIndex] = lastElement;
            }
        }

        private static void MoveUp(int[,] matrix, int colIndex, int moves)
        {
            for (int i = 0; i < moves % matrix.GetLength(0); i++)
            {
                var firstElement = matrix[0, colIndex];

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    matrix[row, colIndex] = matrix[row + 1, colIndex];
                }

                matrix[matrix.GetLength(0) - 1, colIndex] = firstElement;
            }
        }

        private static void MoveLeft(int[,] matrix, int rowIndex, int moves)
        {
            for (int i = 0; i < moves % matrix.GetLength(1); i++)
            {
                var firstElement = matrix[rowIndex, 0];

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    matrix[rowIndex, col] = matrix[rowIndex, col + 1];
                }

                matrix[rowIndex, matrix.GetLength(1) - 1] = firstElement;
            }
        }

        private static void MoveRight(int[,] matrix, int rowIndex, int moves)
        {
            for (int i = 0; i < moves % matrix.GetLength(1); i++)
            {
                var lastElement = matrix[rowIndex, matrix.GetLength(1) - 1];

                for (int col = matrix.GetLength(1) - 1; col >= 1; col--)
                {
                    matrix[rowIndex, col] = matrix[rowIndex, col - 1];
                }

                matrix[rowIndex, 0] = lastElement;
            }
        }
    }
}