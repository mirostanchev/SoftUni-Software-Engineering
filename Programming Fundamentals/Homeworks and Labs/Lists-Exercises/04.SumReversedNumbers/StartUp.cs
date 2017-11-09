namespace _04.SumReversedNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var numbersStr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var sum = 0;

            for (int i = 0; i < numbersStr.Length; i++)
            {
                var number = numbersStr[i].ToCharArray();
                Array.Reverse(number);
                sum += int.Parse(string.Join("", number));
            }

            Console.WriteLine(sum);
        }
    }
}