namespace _06.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var reversed = input.Reverse();

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}