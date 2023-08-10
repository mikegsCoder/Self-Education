using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Bank : IObserver
    {
        public string Name { get; set; }
        IObservable stock;

        public Bank(string name, IObservable obs)
        {
            Name = name;
            stock = obs;

            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 2.5)
            {
                Console.WriteLine("Bank {0} sells Euro at price: {1}", Name, sInfo.Euro);
            }
            else
            {
                Console.WriteLine("Bank {0} buys Euro at price: {1}", Name, sInfo.Euro);
            }
        }
    }
}
