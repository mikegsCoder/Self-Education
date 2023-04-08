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
            //Updates UI and calls gameBoard update
            var clickedButton = sender as Button;

            if (MyGameBoard.currentPlayer == CurrentPlayer.X)
            {
                clickedButton.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#811717"));
            }
            else
            {
                clickedButton.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#126712"));
            }

            clickedButton.Background = Brushes.WhiteSmoke;
            clickedButton.Content = MyGameBoard.currentPlayer;
            clickedButton.IsHitTestVisible = false;

            MyGameBoard.UpdateBoard(clickedButton.Name);
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
 
        }
    }
}
