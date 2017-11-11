namespace _07.ValidTime
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"^[01][\d]:[0-5][\d]:[0-5][\d]\s[AP]M$";
            var reg = new Regex(pattern);

            var sb = new StringBuilder();
            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("END"))
            {
                sb.AppendLine(reg.Match(inputLine).Success ? "valid" : "invalid");
                inputLine = Console.ReadLine();
            }

            Console.Write(sb);
        }
    }
}