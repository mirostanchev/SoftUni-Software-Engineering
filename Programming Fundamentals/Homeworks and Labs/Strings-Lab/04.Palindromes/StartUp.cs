namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] { ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new HashSet<string>();

            foreach (string word in text.OrderBy(w => w))
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool IsPalindrome(string input)
        {
            var isPalindrome = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}