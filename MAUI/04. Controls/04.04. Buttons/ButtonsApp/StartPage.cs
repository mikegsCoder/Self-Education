namespace ButtonsApp
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            Grid grid = new Grid();

            Button button = new Button
            {
                Text = "Click me",
                FontSize = 22,
                BorderWidth = 1,
                BackgroundColor = Colors.LightPink,
                TextColor = Colors.DarkRed,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += OnButtonClicked;

            grid.Children.Add(button);
            Content = grid;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Clicked!";
        }
    }
}
