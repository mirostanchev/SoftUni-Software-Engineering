namespace _03.FormattingNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var a = int.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);

            var hexaNum = a.ToString("X");
            var binary = Convert.ToString(a, 2);

            if (binary.Length > 10)
            {
                binary = binary.Substring(0, 10);
            }

            var changedB = b.ToString("0.00");
            var changedC = c.ToString("0.000");

            Console.WriteLine("|{0}|{1}|{2}|{3}|", hexaNum.PadRight(10), binary.PadLeft(10, '0'), changedB.PadLeft(10), changedC.PadRight(10));
        }
    }
}