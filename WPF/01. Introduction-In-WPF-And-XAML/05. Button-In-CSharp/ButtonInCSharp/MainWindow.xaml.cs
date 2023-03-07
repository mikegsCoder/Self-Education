using System.Windows;
using System.Windows.Controls;

namespace ButtonInCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button();
            myButton.Content = "Button in C#";
            myButton.Width = 120;
            myButton.Height = 40;
            myButton.HorizontalAlignment = HorizontalAlignment.Center;
            myButton.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);

            grid.Children.Add(myButton);
        }
    }
}
