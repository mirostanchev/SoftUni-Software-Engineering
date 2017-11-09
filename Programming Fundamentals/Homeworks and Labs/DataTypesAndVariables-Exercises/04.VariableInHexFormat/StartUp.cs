namespace _04.VariableInHexFormat
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int hexaNum = Convert.ToInt32(input, 16);
            Console.WriteLine(hexaNum);
        }
    }
}