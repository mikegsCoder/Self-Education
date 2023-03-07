using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace _8_Ball
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
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Set Cursor wait mode
            this.Cursor = Cursors.Wait;

            // Sleep the thread
            Thread.Sleep(1000);

            // Get random answer
            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();

            // Return previous Cursor condition
            this.Cursor = null;
        }
    }
}
