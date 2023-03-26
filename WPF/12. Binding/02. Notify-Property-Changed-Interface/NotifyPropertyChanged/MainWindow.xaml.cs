using System.Windows;

namespace NotifyPropertyChanged
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
            Phone phone = (Phone)this.Resources["nexusPhone"];

            if (phone.Company == "Google")
            {
                phone.Company = "LG"; // change from Google to LG
            }
            else
            {
                phone.Company = "Google"; // change from LG to Google
            }
        }
    }
}
