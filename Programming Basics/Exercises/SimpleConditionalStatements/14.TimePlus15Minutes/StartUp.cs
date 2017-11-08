namespace _14.TimePlus15Minutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var inputHours = int.Parse(Console.ReadLine());
            var inputMinutes = int.Parse(Console.ReadLine());

            var totalMinutes = (inputHours * 60) + inputMinutes;
            var newTime = totalMinutes + 15;
            var hours = newTime / 60;
            var minutes = newTime % 60;

            if (hours >= 24)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:00}", hours, minutes);
        }
    }
}