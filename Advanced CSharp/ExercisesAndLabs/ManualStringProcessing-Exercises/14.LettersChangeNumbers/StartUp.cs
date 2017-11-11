namespace _14.LettersChangeNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var sum = 0d;

            foreach (var word in sequence)
            {
                var firstChar = word[0];
                var lastDigit = word[word.Length - 1];
                var number = double.Parse(word.Substring(1, word.Length - 2));

                var currentSum = 0d;

                if (char.IsLower(firstChar))
                {
                    var position = (firstChar - 97) + 1;
                    currentSum += number * position;
                }
                else if (char.IsUpper(firstChar))
                {
                    var position = (firstChar - 65) + 1;
                    currentSum += number / position;
                }

                if (char.IsUpper(lastDigit))
                {
                    var position = (lastDigit - 65) + 1;
                    currentSum -= position;
                }
                else if (char.IsLower(lastDigit))
                {
                    var position = (lastDigit - 97) + 1;
                    currentSum += position;
                }

                sum += currentSum;
            }

            Console.WriteLine("{0:f2}", sum);
        }
    }
}