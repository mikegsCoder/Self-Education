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
        {
            if (MyGameBoard.HasWon)
            {
                return;
            }

            var clickedButton = sender as Button;

            if (MyGameBoard.currentPlayer == CurrentPlayer.X)
            {
                clickedButton!.TextColor = Color.FromArgb("#811717");
            }
            else
            {
                clickedButton!.TextColor = Color.FromArgb("#126712");
            }

            clickedButton.Background = Colors.WhiteSmoke;
            clickedButton.Text = MyGameBoard.currentPlayer.ToString();

            MyGameBoard.UpdateBoard(clickedButton.StyleId);
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            // Restarts Game
            for (int i = 0; i < MyGrid.Count - 1; i++)
            {
                var child = MyGrid[i] as Button;

                child!.Text = null;
                child.IsEnabled = true;
                child.Background = Color.FromArgb("#FFDDDDDD");
            }

            MyGameBoard = new GameBoard();
            BindingContext = MyGameBoard;
        }
    }
}
