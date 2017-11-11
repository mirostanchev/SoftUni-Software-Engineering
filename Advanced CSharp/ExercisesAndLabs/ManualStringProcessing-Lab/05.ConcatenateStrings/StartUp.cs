namespace _05.ConcatenateStrings
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var wordsCount = int.Parse(Console.ReadLine());
            var result = new StringBuilder();

            for (int index = 0; index < wordsCount; index++)
            {
                result.Append($"{Console.ReadLine()} ");
            }

            Console.WriteLine(result);
        }
    }
}