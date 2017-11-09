namespace _10.CenturiesToNanoseconds
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            ulong minutes = (ulong)(60 * hours);
            ulong seconds = minutes * 60;
            ulong miliseconds = seconds * 1000;
            BigInteger microseconds = miliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($@"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} 
                                    seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}