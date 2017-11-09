namespace _03.LastKNumbersSums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var nums = new long[n];
            nums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                var sum = 0L;

                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    sum += nums[j];
                }

                nums[i] = sum;
            

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}