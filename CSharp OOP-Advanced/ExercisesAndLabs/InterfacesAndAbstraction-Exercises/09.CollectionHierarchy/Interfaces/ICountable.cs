namespace _09.CollectionHierarchy.Interfaces
{
    public interface IMyList : IAddable, IRemovable
    {
        int Used { get; }
    }
}