using System.Windows;

namespace ApplicationEvents
{
    public partial class App : Application
    {
        // start one copy of the application
        System.Threading.Mutex mutex;

        private void App_Startup(object sender, StartupEventArgs e)
        {
            bool createdNew;

            string mutName = "Application";

            mutex = new System.Threading.Mutex(true, mutName, out createdNew);
            
            if (!createdNew)
            {
                this.Shutdown();
            }
        }
    }
}
