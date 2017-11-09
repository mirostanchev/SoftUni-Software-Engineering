namespace _15.Substring
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            var hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    var length = jump + 1;
                    string matchedString;

                    if (i + length <= text.Length)
                    {
                        matchedString = text.Substring(i, length);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}