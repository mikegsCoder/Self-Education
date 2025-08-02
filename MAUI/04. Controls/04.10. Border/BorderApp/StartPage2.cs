using Microsoft.Maui.Controls.Shapes;

namespace BorderApp
{
    public class StartPage2 : ContentPage
    {
        // Border RoundRectangle example:
        public StartPage2()
        {
            Grid grid = new Grid() { Padding = 20 };

            Border border = new Border
            {
                Stroke = Colors.Gray,
                StrokeShape = new RoundRectangle { CornerRadius = 20 },
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
