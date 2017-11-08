namespace _01.ConvertFromBase_10ToBase_N
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine().Split().ToArray();
            var baseNum = BigInteger.Parse(inputNums[0]);
            var numsToConvert = BigInteger.Parse(inputNums[1]);
            var result = string.Empty;

            while (numsToConvert > 0)
            {
                var remainder = numsToConvert % baseNum;
                result = remainder.ToString() + result;
                numsToConvert /= baseNum;
            }

            Console.WriteLine(result);
        }
    }
}