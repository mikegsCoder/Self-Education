using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf : Component
    {
        public Leaf(string name)
         : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(name);
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
