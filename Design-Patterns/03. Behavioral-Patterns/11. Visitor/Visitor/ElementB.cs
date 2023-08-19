using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public void OperationB()
        { }
    }
}
