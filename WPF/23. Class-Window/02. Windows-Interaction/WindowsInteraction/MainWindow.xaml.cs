using System.Windows;
using System.Windows.Media;

namespace WindowsInteraction
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow();

            taskWindow.ViewModel = "ViewModel";
            taskWindow.Owner = this;

            taskWindow.Show();

            taskWindow.ShowViewModel();
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in this.OwnedWindows)
            {
                window.Background = new SolidColorBrush(Colors.Blue);

                if (window is TaskWindow)
                {
                    window.Title = "Blue Color";
                }
            }
        }

        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in this.OwnedWindows)
            {
                window.Background = new SolidColorBrush(Colors.White);

                if (window is TaskWindow)
                {
                    window.Title = "Task Window";
                }
            }
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in App.Current.Windows)
            {
                window.Background = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
