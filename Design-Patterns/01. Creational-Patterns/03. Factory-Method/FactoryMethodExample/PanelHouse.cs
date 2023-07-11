using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house built.");
        }
    }
}
