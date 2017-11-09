namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                var j = i + 1;

                if (j > nums.Count - 1)
                {
                    break;
                }

                if (nums[i] == nums[j])
                {
                    var sum = nums[i] + nums[j];
                    nums.RemoveRange(i, 2);
                    nums.Insert(i, sum);
                    j = 0;
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}