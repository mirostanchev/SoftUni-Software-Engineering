namespace _07_08_09.CustomList
{
    using System;
    using System.Linq;

    public class Sorter<T>
        where T : IComparable<T>
    {
        public static CustomList<T> Sort(CustomList<T> elements)
        {
            var temp = elements.GetCollection().OrderBy(x => x).ToList();
            return new CustomList<T>(temp);
        }
    }
}