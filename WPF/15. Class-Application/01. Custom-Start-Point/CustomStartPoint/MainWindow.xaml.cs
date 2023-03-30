using System;
using System.Windows;

namespace CustomStartPoint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [STAThread]
        static void Main()
        {
            App app = new App();
            MainWindow window = new MainWindow();

            window.Title = "Custom Start Point";

            app.Run(window);
        }
    }
}
