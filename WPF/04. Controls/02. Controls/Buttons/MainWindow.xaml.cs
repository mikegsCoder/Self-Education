using System.Windows;

namespace Buttons
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

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Action executed.");
        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // close window
        }
    }
}
