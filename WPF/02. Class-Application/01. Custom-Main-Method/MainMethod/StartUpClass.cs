using System;
using System.Windows;
using MainMethod;

namespace ApplicationSample
{
    public class StartUpClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application app = new Application();
            MainWindow window = new MainWindow();
            app.Run(window);
        }
    }
}
