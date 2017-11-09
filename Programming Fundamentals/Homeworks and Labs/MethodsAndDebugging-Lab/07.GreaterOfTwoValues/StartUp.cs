namespace _07.GreaterOfTwoValues
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                var max = GetMax(first, second);

                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());
                var max = GetMax(first, second);

                Console.WriteLine(max);
            }
            else
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                var max = GetMax(first, second);

                Console.WriteLine(max);
            }
        }

        private static int GetMax(int first, int second)
        {
            var maxNum = first;

            if (second > first)
            {
                maxNum = second;
            }

            return maxNum;
        }

        private static char GetMax(char first, char second)
        {
            var max = first;

            if (second > first)
            {
                max = second;
            }

            return max;
        }

        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}