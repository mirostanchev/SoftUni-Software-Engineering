namespace _05.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;

    public class Box<T>
    {
        public int Compare<T>(List<T> args,T element)
            where T : IComparable<T>
        {
            var count = 0;

            foreach (var item in args)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}