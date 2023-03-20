using System.Windows;
using System.Windows.Input;

namespace CommandRouting
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

        private void WindowBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Application Help");
        }
    }
}
