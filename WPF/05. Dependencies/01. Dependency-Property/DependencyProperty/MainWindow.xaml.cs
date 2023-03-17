using System.Windows;
using System.Windows.Controls;

namespace DependencyProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Example();
        }

        private void Example()
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Hello";
            string text = (string)textBlock.ReadLocalValue(TextBlock.TextProperty); // Hello
            // textBlock.ClearValue(TextBlock.TextProperty); // value cleared

            grid.Children.Add(textBlock);
        }
    }
}
