namespace HelloApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            string xaml = "<Label Text=\".NET MAUI\" FontSize=\"24\" />";

            header.LoadFromXaml(xaml);
        }
    }
}
