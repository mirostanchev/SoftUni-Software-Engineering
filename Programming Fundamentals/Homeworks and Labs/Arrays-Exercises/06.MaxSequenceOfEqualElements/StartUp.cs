namespace _06.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var counter = 1;
            var maxCounter = 1;
            var maxElement = array[0];
            var element = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxElement = element;
                    }
                }
                else
                {
                    counter = 1;
                    element = array[i];
                }
            }

            var output = "";

            for (int j = 1; j <= maxCounter; j++)
            {
                if (j != maxCounter)
                {
                    output += maxElement + " ";
                }
                else
                {
                    output += maxElement;
                }
            }

            Console.WriteLine(output);
        }
    }
}