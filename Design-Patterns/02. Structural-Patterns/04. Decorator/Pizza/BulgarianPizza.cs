using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class BulgarianPizza : Pizza
    {
        public BulgarianPizza()
           : base("Bulgarian pizza")
        { }

        public override int GetCost()
        {
            return 8;
        }
    }
}
