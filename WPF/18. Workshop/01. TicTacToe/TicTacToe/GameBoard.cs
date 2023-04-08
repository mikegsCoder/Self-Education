using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TicTacToe
{
    public class GameBoard : INotifyPropertyChanged
    {
        private int turn = 1;
        private bool hasWon = false;
        private Dictionary<string, int> board;

        public CurrentPlayer currentPlayer;

        public GameBoard()
        {
            currentPlayer = CurrentPlayer.X;

            board = new Dictionary<string, int>()
            {
                {"Top_Left",0 },
                {"Top_Middle",0 },
                {"Top_Right",0 },
                {"Center_Left",0 },
                {"Center_Middle",0 },
                {"Center_Right",0 },
                {"Bottom_Left",0 },
                {"Bottom_Middle",0 },
                {"Bottom_Right",0 }
            };
        }

        public bool HasWon
        {
            get { return hasWon; }
            set { hasWon = value; NotifyPropertyChanged("HasWon"); }
        }

        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool CheckIfWon(string buttonName)
        {
            // Earliest turn a player can win
            if (turn < 5)
            {
                return false;
            }

            return (WonInRow(buttonName)
                    || WonInColumn(buttonName)
                    || WonInDiagonal(buttonName));
        }

        //Checks to see if a player has just won through having three pieces in the tile's row
        private bool WonInRow(string name)
        {
            string row = name.Substring(0, name.IndexOf('_') - 1);

            var elements = board.Where(x => x.Key.StartsWith(row));

            return elements.All(x => x.Value == (int)currentPlayer);
        }

        //Checks to see if player has jsut won thorugh having three pieces in the tile's column
        private bool WonInColumn(string name)
        {
            string col = name.Substring(name.IndexOf('_') + 1);

            var elements = board.Where(x => x.Key.EndsWith(col));

            return elements.All(x => x.Value == (int)currentPlayer);
        }

        //Checks to see if player has just won by having three pieces diagonally
        private bool WonInDiagonal(string name)
        {
            if (name == "Top_Left" || name == "Center_Middle" || name == "Bottom_Right")
            {
                return (board["Center_Middle"] == (int)currentPlayer
                    && board["Bottom_Right"] == (int)currentPlayer
                    && board["Top_Left"] == (int)currentPlayer);
            }

            if (name == "Top_Right" || name == "Center_Middle" || name == "Bottom_Left")
            {
                return (board["Center_Middle"] == (int)currentPlayer
                    && board["Bottom_Left"] == (int)currentPlayer
                    && board["Top_Right"] == (int)currentPlayer);
            }

            return false;
        }
    }
}
