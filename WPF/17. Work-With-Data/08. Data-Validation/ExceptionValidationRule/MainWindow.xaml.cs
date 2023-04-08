using System.Windows;
using System.Windows.Controls;

namespace ExceptionValidationRule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonModel Tom;

        public MainWindow()
        {
            InitializeComponent();

            Tom = new PersonModel();

            DataContext = Tom;
        }

        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            MessageBox.Show(e.Error.ErrorContent.ToString());
        }
    }
}
