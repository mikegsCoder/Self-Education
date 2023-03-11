using System.Windows;
using System.Windows.Controls;

namespace ToolTip
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Controls.ToolTip toolTip = new System.Windows.Controls.ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Header", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Text" });
            toolTip.Content = toolTipPanel;
            button1.ToolTip = toolTip;
        }
    }
}
