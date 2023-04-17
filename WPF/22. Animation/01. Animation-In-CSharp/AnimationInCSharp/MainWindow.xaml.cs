using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace AnimationInCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ButtonAnimation();
        }

        private void ButtonAnimation()
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();

            buttonAnimation.From = 70;
            buttonAnimation.To = 150;
            buttonAnimation.Duration = TimeSpan.FromSeconds(3);
            buttonAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(7));
            buttonAnimation.AutoReverse = true;
            buttonAnimation.RepeatBehavior = new RepeatBehavior(5);
            buttonAnimation.Completed += ButtonAnimation_Completed;

            helloButton.BeginAnimation(Button.WidthProperty, buttonAnimation);
        }

        private void ButtonAnimation_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Animation completed.");
        }
    }
}
