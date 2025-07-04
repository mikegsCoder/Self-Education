namespace SizeAndPositioningApp
{
    public class StartPage1 : ContentPage
    {
        public StartPage1()
        {
            // size example:
            Button button = new Button
            {
                WidthRequest = 100,
                HeightRequest = 50,
                Text = "Click"
            };

            Content = new Grid { Children = { button } };
        }
    }
}
