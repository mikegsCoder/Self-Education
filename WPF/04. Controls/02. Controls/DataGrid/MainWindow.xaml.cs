using System.Collections.Generic;
using System.Windows;

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Example2();
        }

        private void Example2()
        {
            List<Phone> phonesList = new List<Phone>
            {
                new Phone { Title="iPhone 6S", Company="Apple", Price=549 },
                new Phone {Title="Lumia 950", Company="Microsoft", Price=399 },
                new Phone {Title="Nexus 5X", Company="Google", Price=299 }
            };

            phonesGrid1.ItemsSource = phonesList;
        }
    }

    public class Phone
    {
        public string? Title { get; set; }
        public string? Company { get; set; }
        public int Price { get; set; }
    }
}
