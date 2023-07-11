using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    public class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wooden house built.");
        }
    }
}
