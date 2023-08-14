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
