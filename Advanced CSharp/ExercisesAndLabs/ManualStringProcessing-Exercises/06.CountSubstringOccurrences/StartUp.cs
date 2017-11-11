namespace _06.CountSubstringOccurrences
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var word = Console.ReadLine().ToLower();

            var count = 0;
            var index = text.IndexOf(word);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(word, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}