using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Stock : IObservable
    {
        StockInfo sInfo;

        List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            sInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(sInfo);
            }
        }

        public void Market()
        {
            sInfo.USD = GetRandomNumber(1, 2);
            sInfo.Euro = GetRandomNumber(2, 3);

            NotifyObservers();
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();

            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
