namespace _12.CharacterMultiplier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();

            var first = words[0];
            var second = words[1];

            var sum = CalcSum(first, second);
            Console.WriteLine(sum);
        }

        private static long CalcSum(string first, string second)
        {
            var sum = 0L;

            if (first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    sum += (long)first[i] * second[i];
                }

                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else if (second.Length > first.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += (long)first[i] * second[i];
                }

                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            else
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += (long)first[i] * second[i];
                }
            }

            return sum;
        }
    }
}