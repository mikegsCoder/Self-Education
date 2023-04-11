using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EllipseInCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CreateEllipse();
        }

        private void CreateEllipse()
        {
            Ellipse el = new Ellipse();
            el.Width = 200;
            el.Height = 200;
            el.VerticalAlignment = VerticalAlignment.Center;
            el.Fill = Brushes.Green;
            el.Stroke = Brushes.Red;
            el.StrokeThickness = 3;
            grid1.Children.Add(el);
        }
    }
}
