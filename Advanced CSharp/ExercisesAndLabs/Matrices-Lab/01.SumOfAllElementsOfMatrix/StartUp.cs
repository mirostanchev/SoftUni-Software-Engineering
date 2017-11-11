namespace _01.SumOfAllElementsOfMatrix
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
            var sum = 0;

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
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}