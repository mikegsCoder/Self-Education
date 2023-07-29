using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void HandleRequest(int condition);
    }
}
