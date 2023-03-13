using System.Windows;

namespace TextBox
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

        // event handlers:
        private void TextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = (System.Windows.Controls.TextBox)sender;
            MessageBox.Show(textBox.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.SelectionStart = 5;
            textBox1.SelectionLength = 10;
            textBox1.Focus();

            //textBox1.Select(5, 10);
        }
    }
}
