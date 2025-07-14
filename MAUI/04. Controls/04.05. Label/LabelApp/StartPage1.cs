using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelApp
{
    public class StartPage1 : ContentPage
    {
        // Label example:
        public StartPage1()
        {
            Grid grid = new Grid();

            Label label = new Label
            {
                Text = "Hello from MAUI!",
                TextDecorations = TextDecorations.Underline,
                CharacterSpacing = 2,
                FontAttributes = FontAttributes.Bold,
                FontFamily = "Helvetica",
                FontSize = 22,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            grid.Children.Add(label);

            Content = grid;
        }
    }
}
