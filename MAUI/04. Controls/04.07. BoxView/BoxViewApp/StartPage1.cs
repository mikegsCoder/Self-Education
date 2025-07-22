using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxViewApp
{
    public class StartPage1 : ContentPage
    {
        // BoxView example:
        public StartPage1()
        {
            BoxView boxView = new BoxView
            {
                Color = Colors.LightBlue,
                CornerRadius = 8,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Grid grid = new Grid();

            grid.Children.Add(boxView);

            Content = grid;
        }
    }
}
