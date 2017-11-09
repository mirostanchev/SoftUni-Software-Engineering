namespace _03.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var inputArgs = Console.ReadLine().Split().ToArray();

                if (inputArgs[0].Equals("add"))
                {
                    var index = int.Parse(inputArgs[1]);
                    var item = int.Parse(inputArgs[2]);
                    numbers.Insert(index, item);
                }
                else if (inputArgs[0].Equals("addMany"))
                {
                    var index = int.Parse(inputArgs[1]);
                    var elements = inputArgs.Skip(2).Take(inputArgs.Length - 2).Select(int.Parse).ToList();
                    numbers.InsertRange(index, elements);
                }
                else if (inputArgs[0].Equals("contains"))
                {
                    var element = int.Parse(inputArgs[1]);
                    var hasElement = numbers.Contains(element);

                    if (hasElement)
                    {
                        Console.WriteLine(numbers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (inputArgs[0].Equals("remove"))
                {
                    var index = int.Parse(inputArgs[1]);
                    numbers.RemoveAt(index);
                }
                else if (inputArgs[0].Equals("shift"))
                {
                    var count = int.Parse(inputArgs[1]);

                    for (int i = 0; i < count; i++)
                    {
                        var firstNum = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstNum);
                    }
                }
                else if (inputArgs[0].Equals("sumPairs"))
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i);
                        numbers[i] = sum;
                    }
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                    return;
                }
            }
        }
    }
}