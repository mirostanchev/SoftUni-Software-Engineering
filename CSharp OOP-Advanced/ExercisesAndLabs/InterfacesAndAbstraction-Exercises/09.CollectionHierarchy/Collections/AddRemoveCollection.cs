namespace _09.CollectionHierarchy.Collections
{
    using _09.CollectionHierarchy.Interfaces;

    public class AddRemoveCollection : Collection,IAddable,IRemovable
    {
        public int Add(string element)
        {
            base.Elements.Insert(0,element);
            return 0;
        }

        public string Remove()
        {
            string element = base.Elements[base.Elements.Count - 1];
            base.Elements.RemoveAt(base.Elements.Count - 1);
            return element;
        }
    }
}