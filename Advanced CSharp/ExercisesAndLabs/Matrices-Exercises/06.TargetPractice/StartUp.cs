namespace _06.TargetPractice
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

            var snake = Console.ReadLine();
            var shotParam = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var impactRow = shotParam[0];
            var impactCol = shotParam[1];
            var radius = shotParam[2];

            var matrix = new char[rows, cols];
            FillMatrix(snake, matrix);
            Shooting(impactRow, impactCol, radius, matrix);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                RunGravity(matrix, col);
            }

            PrintMatix(matrix);
        }

        private static void RunGravity(char[,] matrix, int col)
        {
            while (true)
            {
                var hasFallen = false;

                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    var topChar = matrix[row - 1, col];
                    var currentChar = matrix[row, col];

                    if (currentChar == ' ' && topChar != ' ')
                    {
                        matrix[row, col] = topChar;
                        matrix[row - 1, col] = ' ';
                        hasFallen = true;
                    }
                }

                if (!hasFallen)
                {
                    break;
                }
            }
        }

        private static void Shooting(int impactRow, int impactCol, int radius, char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var first = Math.Pow(col - impactCol, 2);
                    var second = Math.Pow(row - impactRow, 2);

                    if (first + second <= Math.Pow(radius, 2))
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        private static void FillMatrix(string snake, char[,] matrix)
        {
            var isMovingLeft = true;
            var index = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (isMovingLeft)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }

                        matrix[row, col] = snake[index];
                        index++;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }

                        matrix[row, col] = snake[index];
                        index++;
                    }
                }

                isMovingLeft = !isMovingLeft;
            }
        }

        private static void PrintMatix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}