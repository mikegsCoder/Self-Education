using System.Collections.ObjectModel;

namespace NodeCollection
{
    public class Node
    {
        public string Name { get; set; }

        public ObservableCollection<Node> Nodes { get; set; }
    }
}
