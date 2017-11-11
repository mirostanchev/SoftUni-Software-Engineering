namespace _02.StringLength
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = string.Empty;

            if (input.Length >= 20)
            {
                result = input.Substring(0, 20);
            }
            else
            {
                var asterixCount = 20 - input.Length;
                var asterix = new string('*', asterixCount);
                result = input + asterix;
            }

            Console.WriteLine(result);
        }
    }
}