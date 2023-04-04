using System.Collections.ObjectModel;
using System.Windows;

namespace ObservableCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> phones;

        public MainWindow()
        {
            InitializeComponent();

            phones = new ObservableCollection<string> { "iPhone 6S Plus", "Nexus 6P", "Galaxy S7 Edge" };
            
            phonesList.ItemsSource = phones;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string phone = phoneTextBox.Text;

            // add new phone
            phones.Add(phone);
        }
    }
}
