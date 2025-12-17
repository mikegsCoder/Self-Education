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
        { }
    }
}
