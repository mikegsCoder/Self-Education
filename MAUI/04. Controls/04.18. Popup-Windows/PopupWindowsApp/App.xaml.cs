namespace PopupWindowsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new StartPage1());
            return new Window(new StartPage2());
        }
    }
}