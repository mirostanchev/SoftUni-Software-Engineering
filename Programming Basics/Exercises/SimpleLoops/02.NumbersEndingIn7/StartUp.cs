﻿namespace _02.NumbersEndingIn7
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}