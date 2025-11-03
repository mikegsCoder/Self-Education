using System.Collections.ObjectModel;

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
