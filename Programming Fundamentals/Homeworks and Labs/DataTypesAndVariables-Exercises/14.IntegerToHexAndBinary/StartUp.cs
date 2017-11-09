namespace _14.IntegerToHexAndBinary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string hexaNum = Convert.ToString(num, 16).ToUpper();
            string binaryNum = Convert.ToString(num, 2);

            Console.WriteLine(hexaNum);
            Console.WriteLine(binaryNum);
        }
    }
}