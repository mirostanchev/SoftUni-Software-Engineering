namespace _01.CountWorkDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new List<DateTime>();
            holidays.Add(new DateTime(2016, 01, 01));
            holidays.Add(new DateTime(2016, 03, 03));
            holidays.Add(new DateTime(2016, 05, 01));
            holidays.Add(new DateTime(2016, 05, 06));
            holidays.Add(new DateTime(2016, 05, 24));
            holidays.Add(new DateTime(2016, 09, 06));
            holidays.Add(new DateTime(2016, 09, 22));
            holidays.Add(new DateTime(2016, 11, 01));
            holidays.Add(new DateTime(2016, 12, 24));
            holidays.Add(new DateTime(2016, 12, 25));
            holidays.Add(new DateTime(2016, 12, 26));

            var workingDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var newDate = new DateTime(2016, currentDate.Month, currentDate.Day);

                if (!holidays.Contains(newDate) && currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}