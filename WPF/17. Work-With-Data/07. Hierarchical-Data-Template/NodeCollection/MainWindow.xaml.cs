using System.Collections.ObjectModel;
using System.Windows;

namespace NodeCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Node> nodes;

        public MainWindow()
        {
            InitializeComponent();

            nodes = new ObservableCollection<Node>
            {
                new Node
                {
                    Name ="Europe",
                    Nodes = new ObservableCollection<Node>
                    {
                        new Node {Name="Germany" },
                        new Node {Name="France" },
                        new Node
                        {
                            Name ="Great Britain",
                            Nodes = new ObservableCollection<Node>
                            {
                                new Node {Name="England" },
                                new Node {Name="Scotland" },
                                new Node {Name="Wales" },
                                new Node {Name="Ireland" },
                            }
                        }
                    }
                },
                new Node
                {
                    Name ="Asia",
                    Nodes = new ObservableCollection<Node>
                    {
                        new Node {Name="China" },
                        new Node {Name="Japan" },
                        new Node { Name ="India" }
                    }
                },
                new Node { Name="Africa" },
                new Node { Name="America" },
                new Node { Name="Australia" }
            };

            treeView1.ItemsSource = nodes;
        }
    }
}
