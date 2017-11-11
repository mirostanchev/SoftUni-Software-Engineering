namespace _01.MatchCount
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var searchingWord = Console.ReadLine();
            var text = Console.ReadLine();

            var reg = new Regex(searchingWord);
            var matchesCount = reg.Matches(text).Count;

            Console.WriteLine(matchesCount);
        }
    }
}