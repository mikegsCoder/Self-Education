namespace NavigationPageApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // NavigationPage example:
            //MainPage = new NavigationPage(new MainPage());

            // NavigationPage example:
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromArgb("#2980B9"),
                BarTextColor = Colors.White
            };
        }
    }
}