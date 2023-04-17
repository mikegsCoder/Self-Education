using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace MultiplePropertyAnimationCSharp
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
            // widthAnimation
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = 70;
            widthAnimation.To = 150;
            widthAnimation.Duration = TimeSpan.FromSeconds(5);

            // heightAnimation
            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.From = 30;
            heightAnimation.To = 60;
            heightAnimation.Duration = TimeSpan.FromSeconds(5);

            helloButton.BeginAnimation(Button.WidthProperty, widthAnimation);
            helloButton.BeginAnimation(Button.HeightProperty, heightAnimation);
        }
    }
}
