using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment
{
    public class DeveloperColleague : Colleague
    {
        public DeveloperColleague(Mediator mediator)
           : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message for developer: " + message);
        }
    }
}
