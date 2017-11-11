namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var set = new SortedSet<string>();
            var words = Console.ReadLine().Split(new[] { ' ', '?', '!', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    set.Add(word);
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", set));
        }

        private static bool IsPalindrome(string word)
        {
            var isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }

            return isPalindrome;
        }
    }
}