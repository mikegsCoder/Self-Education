using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExample.Products;

namespace AbstractFactoryExample.Factories
{
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();

        public abstract Weapon CreateWeapon();
    }
}
