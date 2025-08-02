using Microsoft.Maui.Controls.Shapes;

namespace BorderApp
{
    public class StartPage3 : ContentPage
    {
        // Border example:
        public StartPage3()
        {
            Grid grid = new Grid() { Padding = 20 };

            Border border = new Border
            {
                Stroke = Colors.Gray,
                StrokeShape = new RoundRectangle { CornerRadius = 20 },
                BackgroundColor = Color.FromArgb("#e1e1e1")
            };

            Label header = new Label()
            {
                Text = ".NET MAUI",
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 24
            };

            BoxView separator = new BoxView()
            {
                Color = Colors.DarkGray,
                HeightRequest = 2,
                Margin = 10
            };

            Label content = new Label()
            {
                Text = ".NET MAUI - technology for creating cross-platform applications.",
                FontSize = 18
            };

            StackLayout layout = new StackLayout();

            layout.Children.Add(header);
            layout.Children.Add(separator);
            layout.Children.Add(content);

            border.Content = layout;

            grid.Add(border);

            Content = grid;
        }
    }
}
