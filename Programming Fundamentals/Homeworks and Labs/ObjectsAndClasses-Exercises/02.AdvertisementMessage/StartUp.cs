﻿namespace _02.AdvertisementMessage
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var phrases = new string[]
            {
                "Excellent product", "Such a great product", "I always use that product.",
                "Best product of its category", "Exceptional product", "I can’t live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            var authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Ruse", "Varna" };

            var n = int.Parse(Console.ReadLine());
            var rand = new Random();

            for (int i = 0; i < n; i++)
            {
                var currentPhrase = phrases[rand.Next(0, phrases.Length)];
                var currentEvent = events[rand.Next(0, events.Length)];
                var currentAuthor = authors[rand.Next(0, authors.Length)];
                var currentCity = cities[rand.Next(0, cities.Length)];

                Console.WriteLine($"{currentPhrase} {currentEvent} {currentAuthor} - {currentCity}");
            }
        }
    }
}