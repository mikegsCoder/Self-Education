using AbstractFactoryExample.Products;

namespace AbstractFactoryExample.Factories
{
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();

        public abstract Weapon CreateWeapon();
    }
}
