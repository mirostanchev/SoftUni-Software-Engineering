namespace _07.ValidUsernames
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var validUsernames = Console.ReadLine()
                .Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(u => Regex.IsMatch(u, @"\b([a-zA-Z])([\w]){2,24}\b"))
                .ToArray();

            var bestLengthSum = 0;
            var bestFirstUser = string.Empty;
            var bestSecondUser = string.Empty;

            for (int i = 0; i < validUsernames.Length - 1; i++)
            {
                var currentSum = validUsernames[i].Length + validUsernames[i + 1].Length;

                if (currentSum > bestLengthSum)
                {
                    bestLengthSum = currentSum;
                    bestFirstUser = validUsernames[i];
                    bestSecondUser = validUsernames[i + 1];
                }
            }

            Console.WriteLine(bestFirstUser);
            Console.WriteLine(bestSecondUser);
        }
    }
}