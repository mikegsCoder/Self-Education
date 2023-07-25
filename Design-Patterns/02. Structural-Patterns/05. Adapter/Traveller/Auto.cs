using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Driving car on the road.");
        }
    }
}
