namespace _10.UnicodeCharacters
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                sb.Append("\\u" + ((int)text[i]).ToString("X4").ToLower());
            }

            Console.WriteLine(sb);
        }
    }
}