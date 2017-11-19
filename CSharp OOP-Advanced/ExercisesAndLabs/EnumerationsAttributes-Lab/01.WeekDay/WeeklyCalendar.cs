namespace _01.WeekDay
{
    using System.Collections.Generic;

    public class WeeklyCalendar
    {
        public WeeklyCalendar()
        {
            this.Data = new List<WeeklyEntry>();
        }

        public List<WeeklyEntry> Data { get; set; }

        public void AddEntry(string weekday, string notes)
        {
            this.Data.Add(new WeeklyEntry(weekday,notes));
        }
    }
}