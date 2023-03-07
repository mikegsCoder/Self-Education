using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace ApplicationEvents
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += new StartupEventHandler(App_Startup);
            this.Exit += new ExitEventHandler(App_Exit);
            this.SessionEnding += new SessionEndingCancelEventHandler(App_SessionEnding);
            // this.Activated += new EventHandler(App_Activated);
            this.Deactivated += new EventHandler(App_Deactivated);
            this.DispatcherUnhandledException += new DispatcherUnhandledExceptionEventHandler(App_DispatcherUnhandledException);
        }

        protected override void OnActivated(EventArgs e)
        {
            Debug.WriteLine("------> Activated");
            base.OnActivated(e);
        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            // event fires after the Run method
            Debug.WriteLine("------> Startup");
        }

        //void App_Activated(object sender, EventArgs e)
        //{
        //    // event fires when app window becomes active
        //    Debug.WriteLine("------> Activated");
        //}

        void App_Deactivated(object sender, EventArgs e)
        {
            // event fires when app window becomes inactive
            Debug.WriteLine("------> Deactivated");
        }

        void App_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            // event fires when windows session ends
            Debug.WriteLine("------> SessionEnding " + e.ReasonSessionEnding);
            e.Cancel = true; // avoid cancelation
        }

        void App_Exit(object sender, ExitEventArgs e)
        {
            // event fires on exit of the Run method
            Debug.WriteLine("------> Exit");
        }

        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // event fires when in the main thread appears unhandled event
            Debug.WriteLine("------> DispatcherUnhandledException");
            e.Handled = true; // mark event as handled
        }
    }
}
