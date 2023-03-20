using System;
using System.Windows;

namespace TextFileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FileManager fileManager;

        public MainWindow()
        {
            InitializeComponent();

            fileManager = new FileManager();
        }

        private void readBtn_Click(object sender, RoutedEventArgs e)
        {
            string text = fileManager.ReadAllText();

            if (text != null)
            {
                textBox.Text = text;
            }
        }

        private void writeBtn_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;

            if (String.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Your text is empty. Please write something.");

                return;
            }

            fileManager.SaveAllText(text);
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void addToZipBtn_Click(object sender, RoutedEventArgs e)
        {
            fileManager.AddToZip();
        }

        private void unzipBtn_Click(object sender, RoutedEventArgs e)
        {
            fileManager.ExtractFromZip();
        }
    }
}
