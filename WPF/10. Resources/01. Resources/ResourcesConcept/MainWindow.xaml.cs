using System.Windows;
using System.Windows.Media;

namespace ResourcesConcept
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetBuuton2Resources();
        }

        private void SetBuuton2Resources()
        {
            // set resource object
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.LightGray, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 1));

            // add resource to the resource dictionary
            this.Resources.Add("buttonGradientBrush", gradientBrush);

            // set resource to the button
            button2.Background = (Brush)this.TryFindResource("buttonGradientBrush");
            // or like this
            // button1.Background = (Brush)this.Resources["buttonGradientBrush"];
        }
    }
}
