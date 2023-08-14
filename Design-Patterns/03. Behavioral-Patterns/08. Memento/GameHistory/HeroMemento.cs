using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHistory
{
    // Memento
    public class HeroMemento
    {
        public int Bullets { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int bullets, int lives)
        {
            Bullets = bullets;
            Lives = lives;
        }
    }
}
