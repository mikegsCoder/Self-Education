using System.Windows;
using System.Windows.Controls;

namespace Expander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //example 3
            StackPanel expanderPanel = new StackPanel();
            expanderPanel.Children.Add(new CheckBox { Content = "WinForms" });
            expanderPanel.Children.Add(new CheckBox { Content = "WPF" });
            expanderPanel.Children.Add(new CheckBox { Content = "ASP.NET" });

            System.Windows.Controls.Expander expander = new System.Windows.Controls.Expander();
            expander.Header = "Choice your technology";
            expander.Content = expanderPanel;

            stackPanel.Children.Add(expander);
        }

        // event handlers:
        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            ((System.Windows.Controls.Expander)sender).Content = new Button() { Width = 80, Height = 30, Content = "Hello" };
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Expander colapsed");
        }
    }
}
