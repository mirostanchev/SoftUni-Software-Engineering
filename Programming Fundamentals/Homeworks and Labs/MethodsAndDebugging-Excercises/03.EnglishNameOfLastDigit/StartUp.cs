﻿namespace _03.EnglishNameOfLastDigit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = Console.ReadLine();
            var digit = n[n.Length - 1];

            PrintLastDigit(digit);
        }

        private static void PrintLastDigit(char lastDigit)
        {
            switch (lastDigit)
            {
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                case '0':
                    Console.WriteLine("zero");
                    break;
            }
        }
    }
}