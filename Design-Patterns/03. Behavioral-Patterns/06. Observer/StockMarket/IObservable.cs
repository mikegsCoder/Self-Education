using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public interface IObservable
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }
}
