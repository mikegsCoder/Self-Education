using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ItemsPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Phone> Phones { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Phones = new ObservableCollection<Phone>
            {
                new Phone {Id=1, ImagePath="/Images/iPhone6s.jpg", Title="iPhone 6S", Company="Apple" },
                new Phone {Id=2, ImagePath="/Images/Lumia950.jpg", Title="Lumia 950", Company="Microsoft" },
                new Phone {Id=3, ImagePath="/Images/Nexus5x.jpg", Title="Nexus 5X", Company="Google" },
                new Phone {Id=4, ImagePath="/Images/Galaxys6.jpg", Title="Galaxy S6", Company="Samsung"}
            };

            phonesList.ItemsSource = Phones;
        }

        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = (Phone)phonesList.SelectedItem;

            MessageBox.Show(p.Title);
        }
    }
}
