using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingApp
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Name { get; private set; }

        public Grouping(K name, IEnumerable<T> items) : base(items)
        {
            Name = name;
        }
    }
}
