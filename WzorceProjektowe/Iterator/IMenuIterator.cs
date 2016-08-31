namespace WzorceProjektowe.Iterator
{
    public interface IMenuIterator
    {
        bool HasNext();
        object Next { get; }
    }
}