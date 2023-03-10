using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ContentControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button button2 = new Button();
            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new TextBlock { Text = "Set of buttons from C#" });
            stackPanel.Children.Add(new Button { Content = "Red", Height = 20, Background = new SolidColorBrush(Colors.Red) });
            stackPanel.Children.Add(new Button { Content = "Yellow", Height = 20, Background = new SolidColorBrush(Colors.Yellow) });
            stackPanel.Children.Add(new Button { Content = "Green", Height = 20, Background = new SolidColorBrush(Colors.Green) });
            
            button2.Content = stackPanel;
            
            stackPanel1.Children.Add(button2); 
        }
    }
}
