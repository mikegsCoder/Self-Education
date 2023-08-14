namespace GameHistory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot(); // we shot, we have 9 more bullets
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState()); // saving state

            hero.Shoot(); // we shot, we have 8 more bullets

            hero.RestoreState(game.History.Pop()); // restoring state

            hero.Shoot(); // we shot, we have 8 more bullets

            Console.Read();
        }
    }
}