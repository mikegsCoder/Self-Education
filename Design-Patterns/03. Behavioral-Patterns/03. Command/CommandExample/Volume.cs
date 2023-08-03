using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class Volume
    {
        public const int OFF = 0;
        public const int HIGH = 20;
        private int level;

        public Volume()
        {
            level = OFF;
        }

        public void RaiseLevel()
        {
            if (level < HIGH)
            {
                level++;
            }

            Console.WriteLine("Volume level {0}.", level);
        }

        public void DropLevel()
        {
            if (level > OFF)
            {
                level--;
            }

            Console.WriteLine("Volume level {0}.", level);
        }
    }
}
