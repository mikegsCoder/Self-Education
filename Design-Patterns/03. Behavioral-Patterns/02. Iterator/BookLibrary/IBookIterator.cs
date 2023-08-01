namespace BookLibrary
{
    public interface IBookIterator
    {
        bool HasNext();

        Book Next();
    }
}
