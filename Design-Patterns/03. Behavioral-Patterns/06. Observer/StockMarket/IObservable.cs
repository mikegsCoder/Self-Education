namespace StockMarket
{
    public interface IObservable
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }
}
