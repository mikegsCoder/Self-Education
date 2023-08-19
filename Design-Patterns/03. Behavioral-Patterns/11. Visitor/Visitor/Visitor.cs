using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitElementA(ElementA elemA);

        public abstract void VisitElementB(ElementB elemB);
    }
}
