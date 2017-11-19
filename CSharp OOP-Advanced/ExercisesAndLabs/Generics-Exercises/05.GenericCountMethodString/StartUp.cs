namespace _05.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                elements.Add(line);
            }

            var element = Console.ReadLine();
            var box = new Box<string>();
            Console.WriteLine(box.Compare(elements, element));
        }
    }
}