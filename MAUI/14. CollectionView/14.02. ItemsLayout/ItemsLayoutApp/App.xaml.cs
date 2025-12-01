namespace ItemsLayoutApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new MainPage1());
            //return new Window(new MainPage2());
            //return new Window(new MainPage3());

            return new Window(new StartPage1());
        }
    }
}