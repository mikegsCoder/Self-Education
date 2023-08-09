namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();

            ConcreteObservable observable = new ConcreteObservable();

            observable.AddObserver(observer1);
            observable.AddObserver(observer2);

            observable.NotifyObservers();
        }
    }
}