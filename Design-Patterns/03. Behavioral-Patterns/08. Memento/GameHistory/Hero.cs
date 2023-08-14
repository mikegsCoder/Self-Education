using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHistory
{
    // Originator
    public class Hero
    {
        private int bullets = 10; 
        private int lives = 5; 

        public void Shoot()
        {
            if (bullets > 0)
            {
                bullets--;

                Console.WriteLine("We shot. We have {0} more bullets.", bullets);
            }
            else
            {
                Console.WriteLine("No more bullets.");
            }
        }

        // Saving state
        public HeroMemento SaveState()
        {
            Console.WriteLine("Saving game state. Parameters: {0} bullets, {1} lives.", bullets, lives);
            
            return new HeroMemento(bullets, lives);
        }

        // Restoring state
        public void RestoreState(HeroMemento memento)
        {
            bullets = memento.Bullets;
            lives = memento.Lives;

            Console.WriteLine("Restoring game state. Parameters: {0} bullets, {1} lives.", bullets, lives);
        }
    }
}
