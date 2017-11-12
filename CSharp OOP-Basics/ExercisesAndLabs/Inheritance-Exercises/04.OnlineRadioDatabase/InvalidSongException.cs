namespace _04.OnlineRadioDatabase
{
    using System;

    public class InvalidSongException : Exception
    {
        private string message = "Invalid song.";

        protected virtual string ExceptionMessage
        {
            set
            {
                this.message = value;
            }
        }

        public override string Message => message;
    }
}