﻿namespace _04.GenericSwapMethodInteger
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                var line = int.Parse(Console.ReadLine());
                box.Add(line);
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstIndex = indexes[0];
            var secondIndex = indexes[1];
            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box.Print());
        }
    }
}