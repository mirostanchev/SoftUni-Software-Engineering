namespace _09.CollectionHierarchy.Collections
{
    using _09.CollectionHierarchy.Interfaces;

    public class AddCollection : Collection, IAddable
    {
        public int Add(string element)
        {
            base.Elements.Add(element);
            return this.Elements.Count - 1;
        }
    }
}