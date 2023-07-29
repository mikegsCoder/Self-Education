using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int condition)
        {
            // request aggregation

            if (condition == 2)
            {
                // request handled
            }

            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
}
