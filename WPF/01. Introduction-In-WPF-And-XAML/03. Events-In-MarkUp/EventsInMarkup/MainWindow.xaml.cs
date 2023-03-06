using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EventsInMarkup
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

        // MouseEnter event handler
        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Rectangle).Fill = Brushes.Yellow;
        }

        // MouseLeave event handler
        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Rectangle).Fill = Brushes.Green;
        }
    }
}
