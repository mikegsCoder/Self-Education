using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PathGeometryInCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CoordinateSystem();
        }

        private void CoordinateSystem()
        {
            PathGeometry pathGeom = new PathGeometry();
            Path p = new Path();

            LineSegment vertLS = new LineSegment();
            PathFigure vertPF = new PathFigure();

            vertPF.StartPoint = new Point(10, 150);
            vertLS.Point = new Point(10, 10);
            vertPF.Segments.Add(vertLS);
            pathGeom.Figures.Add(vertPF);

            LineSegment horLS = new LineSegment();
            PathFigure horPF = new PathFigure();

            horPF.StartPoint = new Point(10, 150);
            horLS.Point = new Point(150, 150);
            horPF.Segments.Add(horLS);
            pathGeom.Figures.Add(horPF);

            for (byte i = 2; i < 14; i++)
            {
                PathFigure pf = new PathFigure();

                pf.StartPoint = new Point(i * 10, 155);

                LineSegment a = new LineSegment();

                a.Point = new Point(i * 10, 145);
                pf.Segments.Add(a);
                pathGeom.Figures.Add(pf);
            }

            for (byte i = 3; i < 15; i++)
            {
                PathFigure pf = new PathFigure();

                pf.StartPoint = new Point(5, i * 10);

                LineSegment a = new LineSegment();

                a.Point = new Point(15, i * 10);
                pf.Segments.Add(a);
                pathGeom.Figures.Add(pf);
            }

            PolyLineSegment vertArr = new PolyLineSegment();

            vertArr.Points = new PointCollection();
            vertArr.Points.Add(new Point(10, 10));
            vertArr.Points.Add(new Point(15, 15));

            PathFigure vertArrF = new PathFigure();

            vertArrF.StartPoint = new Point(5, 15);
            vertArrF.Segments.Add(vertArr);
            pathGeom.Figures.Add(vertArrF);

            PolyLineSegment horArr = new PolyLineSegment();

            horArr.Points = new PointCollection();

            horArr.Points.Add(new Point(150, 150));
            horArr.Points.Add(new Point(145, 155));

            PathFigure horArrF = new PathFigure();

            horArrF.StartPoint = new Point(145, 145);
            horArrF.Segments.Add(horArr);
            pathGeom.Figures.Add(horArrF);

            p.Data = pathGeom;
            p.Stroke = Brushes.Black;

            grid1.Children.Add(p);
        }
    }
}
