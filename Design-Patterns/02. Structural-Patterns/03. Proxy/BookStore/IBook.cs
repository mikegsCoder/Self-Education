namespace BookStore
{
    public interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}
