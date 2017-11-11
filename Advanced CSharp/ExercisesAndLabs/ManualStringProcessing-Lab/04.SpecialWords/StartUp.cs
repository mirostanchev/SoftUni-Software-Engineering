namespace _04.SpecialWords
{
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public const string Separators = "()[]<>,-!? ‘’";

        public static void Main()
        {
            var specialWords = Console.ReadLine()
                .Split(Separators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var wordsInText = Console.ReadLine()
                .Split(Separators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var sb = new StringBuilder();

            foreach (var specialWord in specialWords)
            {
                var specialWordCount = 0;

                foreach (var word in wordsInText)
                {
                    if (specialWord.Equals(word)) specialWordCount++;
                }

                sb.AppendLine($"{specialWord} - {specialWordCount}");
            }

            Console.Write(sb);
        }
    }
}