using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
}
