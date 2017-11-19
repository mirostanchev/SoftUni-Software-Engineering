﻿namespace _03.GenericSwapMethodString
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
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