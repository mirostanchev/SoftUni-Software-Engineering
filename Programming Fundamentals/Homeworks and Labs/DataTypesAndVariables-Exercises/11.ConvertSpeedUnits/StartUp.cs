namespace _11.ConvertSpeedUnits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalSeconds = seconds + minutes * 60f + hours * 3600f;
            int distanceInKm = distanceInMeters / 1000;
            float totalHours = hours + minutes / 60f + seconds / 3600f;
            float miles = distanceInMeters / 1609f;

            Console.WriteLine(distanceInMeters / totalSeconds);
            Console.WriteLine(distanceInKm / totalHours);
            Console.WriteLine(miles / totalHours);
        }
    }
}