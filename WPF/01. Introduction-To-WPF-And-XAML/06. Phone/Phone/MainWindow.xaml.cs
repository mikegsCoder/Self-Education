using System.Windows;

namespace Phone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Phone1
    {
        public string? Name { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"Phone: {Name}, price: {Price}.";
        }
    }
}
