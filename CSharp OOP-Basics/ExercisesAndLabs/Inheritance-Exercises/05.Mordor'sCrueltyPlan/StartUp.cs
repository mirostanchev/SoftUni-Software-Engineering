namespace _05.Mordor_sCrueltyPlan
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var foodFactory = new FoodFactory();
            var words = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var points = 0;

            for (int i = 0; i < words.Length; i++)
            {
                Food food = foodFactory.CreateFood(words[i]);
                points += food.GetHappinessPoints();
            }

            var moodFactory = new MoodFactory();
            var mood = moodFactory.CreateMood(points);

            Console.WriteLine(points);
            Console.WriteLine(mood.GetName());

        }
    }
}