namespace BorderApp
{
    public class StartPage1 : ContentPage
    {
        // Border example:
        public StartPage1()
        {
            Grid grid = new Grid() { Padding = 20 };

            Border border = new Border
            {
                Stroke = Colors.Gray,
                Content = new Label
                {
                    Text = "Hello from MAUI!",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                },
                BackgroundColor = Color.FromArgb("#e1e1e1")
            };

            grid.Add(border);

            Content = grid;
        }
    }
}
