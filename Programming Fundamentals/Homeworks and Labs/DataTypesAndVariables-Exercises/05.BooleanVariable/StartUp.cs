namespace _05.BooleanVariable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            bool converted = Convert.ToBoolean(input);
            Console.WriteLine(converted ? "Yes" : "No");
        }
    }
}