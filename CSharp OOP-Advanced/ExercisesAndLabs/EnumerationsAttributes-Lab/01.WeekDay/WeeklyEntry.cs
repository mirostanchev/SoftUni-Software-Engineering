namespace _01.WeekDay
{
    using System;

    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        private WeekDay weekday;

        public WeeklyEntry(string weekday, string notes)
        {
            Enum.TryParse(weekday, out this.weekday);
            this.Notes = notes;
        }

        public WeekDay Weekday => this.weekday;
        public string Notes { get; set; }

        public int CompareTo(WeeklyEntry other)
        {
            if (ReferenceEquals(this,other))
            {
                return 0;
            }
            if (ReferenceEquals(null,other))
            {
                return 1;
            }
            var result = this.weekday.CompareTo(other.weekday);

            if (result == 0)
            {
                result = string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.Weekday} - {this.Notes}";
        }
    }
}