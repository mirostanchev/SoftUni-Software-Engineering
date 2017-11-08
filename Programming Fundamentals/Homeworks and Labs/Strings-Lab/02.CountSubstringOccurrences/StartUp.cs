namespace _02.CountSubstringOccurrences
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var index = text.IndexOf(pattern);
            var count = 0;

            while (index != -1)
            {
                count++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}