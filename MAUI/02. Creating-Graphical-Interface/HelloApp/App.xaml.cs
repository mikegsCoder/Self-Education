using System.Reflection.PortableExecutable;

namespace HelloApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell());

            //return new Window(new StartPage());
            //return new Window(new StartPage1());
            return new Window(new StartPage2());
        }
    }
}