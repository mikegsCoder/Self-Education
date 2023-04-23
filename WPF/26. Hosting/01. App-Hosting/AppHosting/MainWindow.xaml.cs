using AppHosting.Contracts;
using System.Windows;

namespace AppHosting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IEnDateService enDateService;
        IBgDateService bgDateService;

        public MainWindow(IEnDateService _enDateService, 
            IBgDateService _bgDateService)
        {
            enDateService = _enDateService;
            bgDateService= _bgDateService;

            InitializeComponent();
        }

        private void EnButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(enDateService.FormatedDate);
        }

        private void BgButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(bgDateService.FormatedDate);
        }
    }
}
