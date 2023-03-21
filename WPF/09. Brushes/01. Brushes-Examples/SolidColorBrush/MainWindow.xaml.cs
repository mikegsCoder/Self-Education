using System.Windows;
using System.Windows.Media;

namespace SolidColorBrush
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            button1.Background = new System.Windows.Media.SolidColorBrush(Colors.Blue);
            button1.Foreground = new System.Windows.Media.SolidColorBrush(Colors.Yellow);

            // or
            // button1.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(207, 255, 255));
        }
    }
}
