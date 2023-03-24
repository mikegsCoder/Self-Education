using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SetResourcesInCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetStaticResource();
            SetDynamicResource();
        }

        private void SetStaticResource()
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.LightGray, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 1));
            this.Resources.Add("buttonGradientBrush1", gradientBrush);

            button1.Background = (Brush)this.TryFindResource("buttonGradientBrush1");
        }

        private void SetDynamicResource()
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.LightGray, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 1));
            this.Resources.Add("buttonGradientBrush2", gradientBrush);

            button2.SetResourceReference(Button.BackgroundProperty, "buttonGradientBrush2");
        }
    }
}
