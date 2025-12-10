namespace NavigationPageApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();

            Title = "Main";

            Button toCommonPageBtn = new Button
            {
                Text = "Common",
                HorizontalOptions = LayoutOptions.Start
            };
            toCommonPageBtn.Clicked += ToCommonPage;

            Button toModalPageBtn = new Button
            {
                Text = "Modal",
                HorizontalOptions = LayoutOptions.Start
            };

            toModalPageBtn.Clicked += ToModalPage;

            Content = new StackLayout { Children = { toCommonPageBtn, toModalPageBtn } };
        }

        private async void ToModalPage(object? sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());
        }

        private async void ToCommonPage(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonPage());
        }
    }
}
