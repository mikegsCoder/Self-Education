using System.Windows;
using System.Windows.Media;

namespace StaticAndDynamicResources
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // this will work with static resource
            SolidColorBrush buttonBrush = (SolidColorBrush)this.TryFindResource("buttonBrush1");
            
            buttonBrush.Color = Colors.LimeGreen;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // this will work only with dynamic resource
            this.Resources["buttonBrush2"] = new SolidColorBrush(Colors.LimeGreen);
        }
    }
}
