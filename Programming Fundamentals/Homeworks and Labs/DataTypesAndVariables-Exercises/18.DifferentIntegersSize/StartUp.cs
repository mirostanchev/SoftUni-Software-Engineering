namespace _18.DifferentIntegersSize
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            bool isSbyte = (num >= sbyte.MinValue) && (num <= sbyte.MaxValue);
            bool isByte = (num >= byte.MinValue) && (num <= byte.MaxValue);
            bool isShort = (num >= short.MinValue) && (num <= short.MaxValue);
            bool isUshort = (num >= ushort.MinValue) && (num <= ushort.MaxValue);
            bool isInt = (num >= int.MinValue) && (num <= int.MaxValue);
            bool isUint = (num >= uint.MinValue) && (num <= uint.MaxValue);
            bool isLong = (num >= long.MinValue) && (num <= long.MaxValue);


            if (num <= long.MaxValue)
            {
                Console.WriteLine($"{num} can fit in:");
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine($"{num} can't fit in any type");
            }
        }
    }
}