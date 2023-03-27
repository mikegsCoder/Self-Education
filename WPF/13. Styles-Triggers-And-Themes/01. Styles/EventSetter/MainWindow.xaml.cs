using System.Windows;
using System.Windows.Controls;

namespace EventSetter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

            MessageBox.Show(clickedButton.Content.ToString());
        }
    }
}
