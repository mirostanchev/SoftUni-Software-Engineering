namespace _07_08_09.CustomList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CustomList<T>
        where T : IComparable<T>
    {
        private IList<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public CustomList(IList<T> collection)
        {
            this.data = new List<T>(collection);
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            var element = this.data[index];
            this.data.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            if (this.data.Contains(element))
            {
                return true;
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            var temp = this.data[index1];
            this.data[index1] = this.data[index2];
            this.data[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;

            foreach (var item in this.data)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public string Print()
        {
            var sb = new StringBuilder();

            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }

        public IList<T> GetCollection()
        {
            return this.data;
        }
    }
}