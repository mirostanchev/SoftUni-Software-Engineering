namespace _12.StringMatrixRotation
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine()
                .Trim()
                .Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var degrees = int.Parse(command[1]);

            var input = new List<string>();
            var rows = 0;
            var cols = int.MinValue;

            while (true)
            {
                var text = Console.ReadLine();

                if (text == "END")
                {
                    break;
                }

                input.Add(text);
                rows++;

                if (text.Length > cols)
                {
                    cols = text.Length;
                }
            }

            var matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentWord = input[row];
                var index = 0;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (index >= currentWord.Length)
                    {
                        matrix[row, col] = ' ';
                    }
                    else
                    {
                        matrix[row, col] = currentWord[index];
                    }

                    index++;
                }
            }

            var rotated = Rotate(matrix, degrees);
            PrintMatrix(rotated);
        }

        private static char[,] Rotate(char[,] matrix, int degrees)
        {
            var numberOfRotates = (degrees % 360) / 90;

            if (numberOfRotates == 1)
            {
                var rotated = new char[matrix.GetLength(1), matrix.GetLength(0)];
                var counterRow = -1;
                var counterCol = 0;

                for (int col = rotated.GetLength(1) - 1; col >= 0; col--)
                {
                    counterRow++;
                    counterCol = 0;
                    for (int row = 0; row < rotated.GetLength(0); row++)
                    {
                        rotated[row, col] = matrix[counterRow, counterCol];
                        counterCol++;
                    }
                }

                return rotated;
            }
            else if (numberOfRotates == 2)
            {
                var rotated = new char[matrix.GetLength(0), matrix.GetLength(1)];
                var counterRow = -1;
                var counterCol = 0;

                for (int row = rotated.GetLength(0) - 1; row >= 0; row--)
                {
                    counterCol = 0;
                    counterRow++;
                    for (int col = rotated.GetLength(1) - 1; col >= 0; col--)
                    {
                        rotated[row, col] = matrix[counterRow, counterCol];
                        counterCol++;
                    }
                }

                return rotated;
            }
            else if (numberOfRotates == 3)
            {
                var rotated = new char[matrix.GetLength(1), matrix.GetLength(0)];
                var counterRow = -1;
                var counterCol = 0;

                for (int col = 0; col < rotated.GetLength(1); col++)
                {
                    counterCol = 0;
                    counterRow++;
                    for (int row = rotated.GetLength(0) - 1; row >= 0; row--)
                    {
                        rotated[row, col] = matrix[counterRow, counterCol];
                        counterCol++;
                    }
                }

                return rotated;
            }

            return matrix;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}