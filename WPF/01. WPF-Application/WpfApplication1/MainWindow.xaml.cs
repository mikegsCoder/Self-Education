using System;
using System.Windows;

namespace WpfApplication1
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

        // Button click handler
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter your name.");
            }
            else 
            {
                MessageBox.Show($"Hello, {textBoxName.Text.Trim()}!");
            }
        }
    }
}
