using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private readonly Aggregate aggregate;
        private int current;

        public ConcreteIterator(Aggregate _aggregate)
        {
            aggregate = _aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;

            current++;

            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }
    }
}
