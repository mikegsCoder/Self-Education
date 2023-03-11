using System.Windows;

namespace CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // create CheckBox
            System.Windows.Controls.CheckBox checkBox5 = new System.Windows.Controls.CheckBox { Content = "New flag", MinHeight = 20, IsChecked = true };
            // set eventhandler
            checkBox5.Checked += checkBox5_Checked;
            // add to StackPanel
            stackPanel.Children.Add(checkBox5);
        }

        // Event handlers:
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox4.Content.ToString() + " checked");
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox4.Content.ToString() + " unchecked");
        }

        private void checkBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox4.Content.ToString() + " intermediate");
        }

        private void checkBox5_Checked(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.CheckBox chBox = (System.Windows.Controls.CheckBox)sender;
            MessageBox.Show(chBox.Content.ToString() + " checked");
        }
    }
}
