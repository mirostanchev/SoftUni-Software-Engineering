﻿namespace _04.OnlineRadioDatabase
{
    public class InvalidSongNameException : InvalidSongException
    {
        public override string Message => "Song name should be between 3 and 30 symbols.";
    }
}