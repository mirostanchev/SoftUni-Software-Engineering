namespace _01.ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T>
    {
        private List<T> data;
        private int internalIndex;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.internalIndex = 0;
        }

        public ListyIterator(List<T> coll)
        {
            this.data = coll;
        }

        public void Create(params T[] tokens)
        {
            if (tokens.Length != 0)
            {
                this.data = new List<T>();
            }
            else
            {
                this.data = new List<T>(tokens);
            }
        }

        public bool Move()
        {
            if (this.internalIndex + 1 < this.data.Count)
            {
                this.internalIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.internalIndex + 1 < this.data.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.data.Any())
            {
                Console.WriteLine(this.data[this.internalIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}