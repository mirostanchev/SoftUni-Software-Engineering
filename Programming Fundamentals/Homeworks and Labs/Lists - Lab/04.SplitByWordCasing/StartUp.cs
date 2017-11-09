namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var upperCase = FindUpperCase(input);
            var lowerCase = FindLowerCase(input);
            var mixedCase = FindMixedCase(input);


            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }

        public static List<string> FindMixedCase(List<string> input)
        {
            var mixedCase = new List<string>();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if ((item[0] >= 65 && item[0] <= 90) && (item[i] >= 97 && item[i] <= 122))
                    {
                        mixedCase.Add(item);
                        break;
                    }
                    else if (!(item[i] >= 65 && item[i] <= 90) && !(item[i] >= 97 && item[i] <= 122))
                    {
                        mixedCase.Add(item);
                        break;
                    }
                }
            }

            return mixedCase;
        }

        public static List<string> FindLowerCase(List<string> input)
        {
            var lowerCase = new List<string>();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (!(item[i] >= 97 && item[i] <= 122))
                    {
                        break;
                    }
                    else if (i == item.Length - 1)
                    {
                        lowerCase.Add(item);
                    }
                }
            }

            return lowerCase;
        }

        public static List<string> FindUpperCase(List<string> input)
        {
            var upperCase = new List<string>();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (!(item[i] >= 65 && item[i] <= 90))
                    {
                        break;
                    }
                    else if (i == item.Length - 1)
                    {
                        upperCase.Add(item);
                    }
                }
            }

            return upperCase;
        }
    }
}