namespace _06.RhombusOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var counterSpaces = num - 1;

            for (int i = 1; i <= num; i++)
            {
                var asterix = StringCreater(" *", i - 1);
                Console.WriteLine("{0}*{1}", new string(' ', counterSpaces), asterix);

                counterSpaces--;
            }

            var secondCounter = 1;
            var asterixCounter = num - 1;

            for (int i = 1; i <= num - 1; i++)
            {
                var asterix = StringCreater("* ", asterixCounter);
                Console.WriteLine("{0}{1}", new string(' ', secondCounter), asterix);

                secondCounter++;
                asterixCounter--;
            }
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