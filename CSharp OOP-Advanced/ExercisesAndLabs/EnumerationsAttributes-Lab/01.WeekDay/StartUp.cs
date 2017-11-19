﻿namespace _01.WeekDay
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var calendar = new WeeklyCalendar();
            calendar.AddEntry("Monday", "Internal meeting");
            calendar.AddEntry("Tuesday", "Create presentation");
            calendar.AddEntry("Tuesday", "Create lab and exercise");
            calendar.AddEntry("Thursday", "Enum Lecture");
            calendar.AddEntry("Monday", "Second internal meeting");

            var ordered = calendar.Data.OrderBy(n => n).ToList();
            foreach (var weeklyEntry in ordered)
            {
                Console.WriteLine(weeklyEntry);
            }
        }
    }
}