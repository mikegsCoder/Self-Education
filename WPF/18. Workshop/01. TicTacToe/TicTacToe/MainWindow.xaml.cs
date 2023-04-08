using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameBoard MyGameBoard = new GameBoard();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = MyGameBoard;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
 
        }
    }
}
