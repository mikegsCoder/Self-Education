using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moving on electricity.");
        }
    }
}
