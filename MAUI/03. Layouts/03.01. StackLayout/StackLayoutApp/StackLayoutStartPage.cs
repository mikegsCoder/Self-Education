namespace StackLayoutApp
{
    public class StackLayoutStartPage : ContentPage
    {
        Label label1 = new Label()
        {
            Text = "First label",
            TextColor = Colors.Red
        };

        Label label2 = new Label()
        {
            Text = "Second label",
            TextColor = Colors.Blue
        };

        Label label3 = new Label()
        {
            Text = "Third label",
            TextColor = Colors.Green
        };

        public StackLayoutStartPage()
        {
            //StackLayout example:
            //StackLayout stackLayout = new StackLayout()
            //{
            //    Children = { label1, label2, label3 }
            //};

            //stackLayout.Orientation = StackOrientation.Horizontal;

            // VerticalStackLayout example:
            VerticalStackLayout stackLayout = new VerticalStackLayout()
            {
                Children = { label1, label2, label3 }
            };

            stackLayout.Spacing = 5;

            Content = stackLayout;
        }
    }
}
