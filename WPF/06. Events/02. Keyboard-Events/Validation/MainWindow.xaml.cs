using System;
using System.Windows;
using System.Windows.Input;

namespace Validation
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
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;

            if (!Int32.TryParse(e.Text, out val) && e.Text != "-")
            {
                e.Handled = true; // if not integer or "-" cancel input
            }
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true; // if space cancel input
            }
        }
    }
}
