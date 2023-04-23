using System.Windows;

namespace AppHosting
{
    public class App : Application
    {
        readonly MainWindow mainWindow;

        // get MainWindow object using dependency injection
        public App(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            mainWindow.Show();  // show MainWindow
            base.OnStartup(e);
        }
    }
}
