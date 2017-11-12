namespace _05.DateModifier
{
    using System;

    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
        }

        public int Calc()
        {
            var firstDateArgs = this.firstDate.Split();
            var secondDateArgs = this.secondDate.Split();

            var firstDate = new DateTime(int.Parse(firstDateArgs[0]), int.Parse(firstDateArgs[1]), int.Parse(firstDateArgs[2]));
            var secondDate = new DateTime(int.Parse(secondDateArgs[0]), int.Parse(secondDateArgs[1]), int.Parse(secondDateArgs[2]));

            return Math.Abs((secondDate - firstDate).Days);
        }
    }
}