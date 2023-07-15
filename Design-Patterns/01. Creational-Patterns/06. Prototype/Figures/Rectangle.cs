namespace Figures
{
    public class Rectangle : IFigure
    {
        int width;
        int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(width, height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Rectangle with height {0} and width {1}.", height, width);
        }
    }
}
