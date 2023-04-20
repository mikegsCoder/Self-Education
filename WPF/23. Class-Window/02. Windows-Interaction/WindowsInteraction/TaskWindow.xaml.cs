using System.Windows;
using System.Windows.Media;

namespace WindowsInteraction
{
    /// <summary>
    /// Interaction logic for TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public string ViewModel { get; set; }

        public TaskWindow()
        {
            InitializeComponent();
        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Background = new SolidColorBrush(Colors.Red);
        }

        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Background = new SolidColorBrush(Colors.White);
        }
    }
}
