namespace _06.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new List<double>();
            
            for (int i = 0; i < n; i++)
            {
                var line = double.Parse(Console.ReadLine());
                elements.Add(line);
            }

            var element = double.Parse(Console.ReadLine());
            var box = new Box<double>();
            Console.WriteLine(box.Compare(elements, element));
        }
    }
}