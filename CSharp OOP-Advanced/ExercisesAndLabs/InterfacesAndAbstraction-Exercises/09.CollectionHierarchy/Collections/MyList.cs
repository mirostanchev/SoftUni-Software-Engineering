﻿namespace _09.CollectionHierarchy.Collections
{
    using _09.CollectionHierarchy.Interfaces;

    public class MyList : Collection,IMyList
    {
        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string element = base.Elements[0];
            base.Elements.RemoveAt(0);
            return element;
        }

        public int Used
        {
            get { return base.Elements.Count; }
        }
    }
}