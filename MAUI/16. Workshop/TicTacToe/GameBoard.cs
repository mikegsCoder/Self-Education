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

        internal void UpdateBoard(string styleId)
        {
            throw new NotImplementedException();
        }

        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
