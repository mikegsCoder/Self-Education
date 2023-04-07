using System.Collections.ObjectModel;
using System.Windows;

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Company> companies = new ObservableCollection<Company>()
            {
                new Company
                {
                    Name = "Samsung",
                    Phones = new ObservableCollection<Smartphone>
                    {
                        new Smartphone {Title = "Galaxy Note 7" },
                        new Smartphone {Title = "Galaxy S 7" }
                    }
                },
                new Company
                {
                    Name = "Apple",
                    Phones = new ObservableCollection<Smartphone>
                    {
                        new Smartphone { Title="iPhone 7" },
                        new Smartphone { Title="iPhone 6S"}
                    }
                },
                new Company
                {
                    Name="Xiaomi",
                    Phones = new ObservableCollection<Smartphone>
                    {
                        new Smartphone {Title="Redmi Note 2" },
                        new Smartphone {Title="Mi5" }
                    }
                }
            };

            mainMenu.ItemsSource = companies;
        }
    }
}
