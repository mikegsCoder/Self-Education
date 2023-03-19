using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyboardEvents
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
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && e.Key == Key.F1)
            {
                MessageBox.Show("HELLO");
            }
            else if (e.Key == Key.OemQuotes)
            {
                textBlock1.Text += "'";
            }
            else
            {
                textBlock1.Text += e.Key.ToString();
            }
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            textBlock2.Text += e.Text;
        }
    }
}
