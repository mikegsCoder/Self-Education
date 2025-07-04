namespace SizeAndPositioningApp
{
    public class StartPage2 : ContentPage
    {
        public StartPage2()
        {
            // margin and padding example:
            var stackLayout = new StackLayout
            {
                Padding = new Thickness(60),
                Children =
                {
                    new BoxView { Color = Colors.Blue, Margin = new Thickness (50), HeightRequest = 100 },
                    new BoxView { Color = Colors.Red, Margin = new Thickness (50), HeightRequest = 100 }
                }
            };

            Content = stackLayout;
        }
    }
}
