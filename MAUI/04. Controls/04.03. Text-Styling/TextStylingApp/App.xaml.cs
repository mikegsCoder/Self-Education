namespace TextStylingApp
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

            //return new Window(new StartPage1());
            //return new Window(new StartPage2());
            //return new Window(new StartPage3());
            //return new Window(new StartPage4());
            return new Window(new StartPage5());
        }
    }
}