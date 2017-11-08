namespace _05.SquareFrame
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var dashes = StringCreater("- ", number - 2);

            Console.WriteLine("{0} {1}{0}", "+", dashes);

            for (int i = 1; i < number - 1; i++)
            {
                Console.WriteLine("{0} {1}{0}", "|", dashes);
            }

            Console.WriteLine("{0} {1}{0}", "+", dashes);
        }
        public static string StringCreater(string text, int repeatCount)
        {
            var repeatedText = string.Empty;

            for (int currentCount = 0; currentCount < repeatCount; currentCount++)
            {
                repeatedText += text;
            }

            return repeatedText;
        }
    }
}