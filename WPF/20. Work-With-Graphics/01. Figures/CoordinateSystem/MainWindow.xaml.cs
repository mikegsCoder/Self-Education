using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CoordinateSystem
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
            Line vertL = new Line();
            vertL.X1 = 10;
            vertL.Y1 = 150;
            vertL.X2 = 10;
            vertL.Y2 = 10;
            vertL.Stroke = Brushes.Black;

            grid1.Children.Add(vertL);

            Line horL = new Line();
            horL.X1 = 10;
            horL.X2 = 150;
            horL.Y1 = 150;
            horL.Y2 = 150;
            horL.Stroke = Brushes.Black;

            grid1.Children.Add(horL);

            for (byte i = 2; i < 14; i++)
            {
                Line a = new Line();
                a.X1 = i * 10;
                a.X2 = i * 10;
                a.Y1 = 155;
                a.Y2 = 145;
                a.Stroke = Brushes.Black;

                grid1.Children.Add(a);
            }

            for (byte i = 2; i < 14; i++)
            {
                Line a = new Line();

                a.X1 = 5;
                a.X2 = 15;
                a.Y1 = i * 10;
                a.Y2 = i * 10;
                a.Stroke = Brushes.Black;

                grid1.Children.Add(a);
            }

            Polyline vertArr = new Polyline();

            vertArr.Points = new PointCollection();

            vertArr.Points.Add(new Point(5, 15));
            vertArr.Points.Add(new Point(10, 10));
            vertArr.Points.Add(new Point(15, 15));

            vertArr.Stroke = Brushes.Black;

            grid1.Children.Add(vertArr);

            Polyline horArr = new Polyline();

            horArr.Points = new PointCollection();

            horArr.Points.Add(new Point(145, 145));
            horArr.Points.Add(new Point(150, 150));
            horArr.Points.Add(new Point(145, 155));

            horArr.Stroke = Brushes.Black;

            grid1.Children.Add(horArr);
        }
    }
}
