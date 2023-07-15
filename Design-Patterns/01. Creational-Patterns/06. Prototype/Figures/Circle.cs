using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Circle with radius {0}.", radius);
        }
    }
}
