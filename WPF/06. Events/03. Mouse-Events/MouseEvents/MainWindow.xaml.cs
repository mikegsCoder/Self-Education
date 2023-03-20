using System.Windows;
using System.Windows.Input;

namespace MouseEvents
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
        private void textBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(textBox1, textBox1.Text, DragDropEffects.Copy);
        }

        private void button1_Drop(object sender, DragEventArgs e)
        {
            button1.Content = e.Data.GetData(DataFormats.Text);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Got Focus");
        }
    }
}
