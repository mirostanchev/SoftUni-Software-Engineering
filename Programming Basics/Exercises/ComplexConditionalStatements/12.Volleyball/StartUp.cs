namespace _12.Volleyball
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var typeYear = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsInTravel = int.Parse(Console.ReadLine());

            var weekends = 48d;
            var weekendsInSofia = weekends - weekendsInTravel;
            var saturdayGamesInSofia = weekendsInSofia * (3.0 / 4);
            var gamesInHisCity = weekendsInTravel;
            var holidayGamesInSofia = holidays * (2.0 / 3);
            var totalGames = saturdayGamesInSofia + gamesInHisCity + holidayGamesInSofia;

            if (typeYear == "leap")
            {
                totalGames += totalGames * 0.15;
            }

            Console.WriteLine(Math.Truncate(totalGames));
        }
    }
}