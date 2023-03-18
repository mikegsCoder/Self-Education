using System.Windows;

namespace CustomProperties
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

        // event handler:
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phone phone = (Phone)this.Resources["iPhone6s"]; // get resource by key
            MessageBox.Show(phone.Price.ToString());
        }
    }
}
