namespace _04.Froggy
{
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var elements = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var lake = new Lake<int>(elements);
            var sb = new StringBuilder();

            foreach (var element in lake)
            {
                sb.Append($"{element}, ");
            }

            Console.WriteLine(sb.ToString().TrimEnd(',', ' '));

        }
    }
}