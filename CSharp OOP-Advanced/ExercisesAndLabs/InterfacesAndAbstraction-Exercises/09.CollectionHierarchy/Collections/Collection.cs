namespace _09.CollectionHierarchy.Collections
{
    using System.Collections.Generic;

    public abstract class Collection
    {
        private List<string> elements;

        protected Collection()
        {
            this.elements = new List<string>(100);
        }

        public List<string> Elements
        {
            get { return this.elements; }
        }
    }
}