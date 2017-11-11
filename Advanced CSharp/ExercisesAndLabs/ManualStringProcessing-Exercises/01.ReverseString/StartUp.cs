namespace _01.ReverseString
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var arr = input.ToCharArray();
            Array.Reverse(arr);
            var result = new string(arr);
            Console.WriteLine(result);
        }
    }
}