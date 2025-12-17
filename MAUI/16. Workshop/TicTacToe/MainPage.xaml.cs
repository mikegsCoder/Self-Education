using Microsoft.Maui.Controls;
using System.Xml;

namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {
        public GameBoard MyGameBoard;

        public MainPage()
        {
            InitializeComponent();

            MyGameBoard = new GameBoard();
            BindingContext = MyGameBoard;

            GameWonLbl.SetBinding(Label.IsVisibleProperty, "HasWon");
        }

        public void Button_Click(object sender, EventArgs e)
        { }

        private void Restart_Click(object sender, EventArgs e)
        {
            //Restarts Game
            for (int i = 0; i < MyGrid.Count - 1; i++)
            {
                var child = MyGrid[i] as Button;

                child.Text = null;
                child.IsEnabled = true;
                child.Background = Color.FromArgb("#FFDDDDDD");
            }

            MyGameBoard = new GameBoard();
            BindingContext = MyGameBoard;
        }
    }
}
