namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSales = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var town = currentSales[0];
                var price = decimal.Parse(currentSales[2]);
                var quantity = decimal.Parse(currentSales[3]);

                var totalPrice = price * quantity;

                if (!sales.ContainsKey(town))
                {
                    sales[town] = 0;
                }

                sales[town] += totalPrice;
            }

            foreach (var report in sales)
            {
                Console.WriteLine($"{report.Key} -> {report.Value:f2}");
            }
        }
    }
}