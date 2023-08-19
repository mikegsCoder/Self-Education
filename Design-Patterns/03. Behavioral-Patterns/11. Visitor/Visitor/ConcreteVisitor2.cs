using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visitor
{
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }

        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }
}
