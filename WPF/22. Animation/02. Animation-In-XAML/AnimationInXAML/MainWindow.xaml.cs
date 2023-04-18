using System;
using System.Windows;

namespace AnimationInXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAnimation_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Animation completed.");
        }
    }
}
