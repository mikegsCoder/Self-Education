using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ApplicationResources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            kitty.Source = new BitmapImage(new Uri("Images/kitty.jpg", UriKind.Relative));
        }
    }
}
