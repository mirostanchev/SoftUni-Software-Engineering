﻿namespace _04.Elevator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            if (people % capacity == 0)
            {
                courses = people / capacity;
            }
            else
            {
                courses = (people / capacity) + 1;
            }

            Console.WriteLine(courses);
        }
    }
}