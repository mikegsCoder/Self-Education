namespace GridApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new MainPage());

            //return new Window(new GridStartPage1());
            //return new Window(new GridStartPage2());
            //return new Window(new GridStartPage3());
            return new Window(new GridStartPage4());
        }
    }
}