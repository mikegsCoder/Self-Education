using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.Products
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("We fly.");
        }
    }
}
