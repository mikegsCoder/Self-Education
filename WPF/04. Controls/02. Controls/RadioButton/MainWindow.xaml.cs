using System.Windows;

namespace RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Controls.RadioButton rb = new System.Windows.Controls.RadioButton { IsChecked = true, GroupName = "Languages", Content = "JavaScript" };
            rb.Checked += RadioButton_Checked;
            stackPanel.Children.Add(rb);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.RadioButton pressed = (System.Windows.Controls.RadioButton)sender;
            MessageBox.Show(pressed.Content.ToString());
        }
    }
}
