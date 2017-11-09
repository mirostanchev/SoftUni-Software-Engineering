namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToList();

            var result = new List<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<string> nums = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}