namespace NavigationPageApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // NavigationPage example:
            MainPage = new NavigationPage(new MainPage());
        }
    }
}