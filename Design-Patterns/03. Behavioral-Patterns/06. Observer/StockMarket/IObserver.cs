using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public interface IObserver
    {
        void Update(Object obj);
    }
}
