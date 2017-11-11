namespace _04.PascalTriangle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new long[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new long[i + 1];
            }

            arr[0][0] = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i + 1][j] += arr[i][j];
                    arr[i + 1][j + 1] += arr[i][j];
                }
            }

            for (int r = 0; r < arr.Length; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    Console.Write($"{arr[r][c]} ");
                }

                Console.WriteLine();
            }
        }
    }
}