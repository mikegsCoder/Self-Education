using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        { }

        public override int GetCost()
        {
            return 10;
        }
    }
}
