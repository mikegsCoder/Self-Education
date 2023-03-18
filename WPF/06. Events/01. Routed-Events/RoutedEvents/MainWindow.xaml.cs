using System.Windows;

namespace RoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button1.Click += Button1_Click;
        }

        // event handler from XAML:
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi from Button_Click.");
        }

        // event handler included in constructor:
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi from Button1_Click.");
        }
    }
}
