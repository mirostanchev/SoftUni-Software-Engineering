namespace _04.ConvertFromBase_10ToBase_N
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var toBase = int.Parse(input[0]);
            var num = BigInteger.Parse(input[1]);

            var result = string.Empty;

            while (num > 0)
            {
                result += num % toBase;
                num /= toBase;
            }

            var arr = result.ToCharArray();
            Array.Reverse(arr);
            var reversed = new string(arr);
            Console.WriteLine(reversed);
        }
    }
}