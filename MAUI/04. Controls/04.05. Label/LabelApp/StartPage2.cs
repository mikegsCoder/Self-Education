using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelApp
{
    public class StartPage2 : ContentPage
    {
        //FormattedString example:
        public StartPage2()
        {
            Grid grid = new Grid();
            Label header = new Label();
            FormattedString formattedString = new FormattedString();
            
            formattedString.Spans.Add(new Span
            {
                Text = "Hello ",
                FontSize = 22
            });

            formattedString.Spans.Add(new Span
            {
                Text = "from",
                TextColor = Colors.DarkRed,
                BackgroundColor = Colors.LightPink,
            });

            formattedString.Spans.Add(new Span
            {
                Text = " MAUI!",
                FontAttributes = FontAttributes.Bold
            });

            header.FormattedText = formattedString;

            header.VerticalOptions = LayoutOptions.Center;
            header.HorizontalOptions = LayoutOptions.Center;

            grid.Children.Add(header);

            Content = grid;
        }
    }
}
