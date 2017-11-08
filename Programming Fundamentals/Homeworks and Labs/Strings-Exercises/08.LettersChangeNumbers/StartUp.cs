namespace _08.LettersChangeNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var totalSum = 0m;

            for (int i = 0; i < inputLine.Length; i++)
            {
                var leftLetter = char.Parse(inputLine[i].Substring(0, 1));
                var rightLetter = char.Parse(inputLine[i].Substring(inputLine[i].Length - 1));
                var number = decimal.Parse(inputLine[i].Substring(1, inputLine[i].Length - 2));

                if (char.IsUpper(leftLetter))
                {
                    number = number / (leftLetter - 64);
                }
                else if (char.IsLower(leftLetter))
                {
                    number = number * (leftLetter - 96);
                }

                if (char.IsUpper(rightLetter))
                {
                    number = number - (rightLetter - 64);
                }
                else if (char.IsLower(rightLetter))
                {
                    number = number + (rightLetter - 96);
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2} ");
        }
    }
}