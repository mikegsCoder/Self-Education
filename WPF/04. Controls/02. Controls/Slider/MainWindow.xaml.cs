using System.Windows;

namespace Slider
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

        //event handler:
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((System.Windows.Controls.Slider)sender).SelectionEnd = e.NewValue;
            info.Content = e.NewValue.ToString();
        }
    }
}
