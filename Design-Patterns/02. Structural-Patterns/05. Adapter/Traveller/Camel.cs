using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camel walks in the desert.");
        }
    }
}
