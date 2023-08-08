using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moving on petrol.");
        }
    }
}
