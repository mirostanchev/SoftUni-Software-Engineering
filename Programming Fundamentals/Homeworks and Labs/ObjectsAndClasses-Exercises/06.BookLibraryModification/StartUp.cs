namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                var bookInfo = Console.ReadLine().Split();
                var title = bookInfo[0];
                var date = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (!result.ContainsKey(title))
                {
                    result[title] = date;
                }

                result[title] = date;
            }

            var searchedDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in result.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                if (item.Value > searchedDate)
                {
                    var date = item.Value.ToString("dd.MM.yyyy");
                    Console.WriteLine($"{item.Key} -> {date}");
                }
            }
        }
    }
}