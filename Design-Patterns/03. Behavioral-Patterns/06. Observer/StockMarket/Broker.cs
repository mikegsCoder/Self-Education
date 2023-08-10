namespace StockMarket
{
    public class Broker : IObserver
    {
        public string Name { get; set; }
        IObservable stock;

        public Broker(string name, IObservable obs)
        {
            Name = name;
            stock = obs;

            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.USD > 1.5)
            {
                Console.WriteLine("Broker {0} sells USD at price: {1}.", Name, sInfo.USD);
            }
            else
            {
                Console.WriteLine("Broker {0} buys USD at price: {1}", Name, sInfo.USD);
            }
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
