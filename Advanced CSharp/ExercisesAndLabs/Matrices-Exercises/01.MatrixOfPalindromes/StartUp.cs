namespace _01.MatrixOfPalindromes
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var matrixInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var rows = matrixInfo[0];
            var cols = matrixInfo[1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var firstLastLetterIndex = i;
                    var middleLetterIndex = i + j;

                    var result = alphabet[firstLastLetterIndex].ToString() + alphabet[middleLetterIndex] +
                                 alphabet[firstLastLetterIndex];
                    Console.Write($"{result} ");
                }

                Console.WriteLine();
            }
        }
    }
}