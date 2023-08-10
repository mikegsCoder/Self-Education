namespace StockMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("New Bank", stock);
            Broker broker = new Broker("John Smith", stock);

            stock.Market();
            broker.StopTrade();
            stock.Market();

            Console.Read();
        }
    }
}