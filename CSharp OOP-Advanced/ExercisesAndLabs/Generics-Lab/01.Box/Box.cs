﻿namespace _01.Box
{
    using System.Collections.Generic;

    public class Box<T>
    {
        private IList<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove()
        {
            var lastElement = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count - 1);
            return lastElement;
        }

        public int Count
        {
            get { return this.elements.Count; }
        }
    }
}