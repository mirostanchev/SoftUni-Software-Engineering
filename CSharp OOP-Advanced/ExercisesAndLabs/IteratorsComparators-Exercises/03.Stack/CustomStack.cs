namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomStack<T> : IEnumerable<T>
    {
        private Stack<T> data;

        public CustomStack()
        {
            this.data = new Stack<T>();
        }

        public void Push(params T[] elements)
        {
            if (elements.Length != 0)
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    this.data.Push(elements[i]);
                }
            }
        }

        public void Pop()
        {
            if (this.data.Any())
            {
                this.data.Pop();
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data.ToArray()[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}