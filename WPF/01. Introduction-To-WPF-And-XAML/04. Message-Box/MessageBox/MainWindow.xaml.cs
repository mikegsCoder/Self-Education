using System.Windows;

namespace MessageBox
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
            string text = textBox1.Text;

            if (text != "")
            {
                System.Windows.MessageBox.Show(text);
            }
        }
    }
}
