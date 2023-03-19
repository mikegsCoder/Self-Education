using System.Windows;
using System.Windows.Controls;

namespace AttachedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // attach handler:
            menuSelector.AddHandler(RadioButton.CheckedEvent, new RoutedEventHandler(RadioButton_Click));
        }

        // event handler:
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton selectedRadio = (RadioButton)e.Source;
            textBlock1.Text = "Your choice is: " + selectedRadio.Content.ToString();
        }
    }
}
