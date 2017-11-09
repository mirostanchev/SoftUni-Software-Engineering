namespace _19.TheaThePhotographer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int pictureCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long filteredPictures = (long)Math.Ceiling((double)pictureCount * filterFactor / 100);
            long totalFilterTime = (long)pictureCount * filterTime;
            long totalUploadTime = filteredPictures * uploadTime;
            long totalSeconds = totalFilterTime + totalUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
        }
    }
}