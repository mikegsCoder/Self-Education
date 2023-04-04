using System.Windows;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Phone MyPhone { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            MyPhone = new Phone
            {
                Name = "Lumia 630",
                Company = new Company { Title = "Microsoft" },
                Price = 500
            };

            this.DataContext = MyPhone;
        }
    }
}
