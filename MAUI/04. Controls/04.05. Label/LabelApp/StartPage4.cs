using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelApp
{
    public class StartPage4 : ContentPage
    {
        //Label click handling example:
        public StartPage4()
        {
            Grid grid = new Grid();

            Label label = new Label
            {
                Text = "Hello from MAUI!",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 22
            };

            TapGestureRecognizer tapGesture = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 2
            };

            int count = 0;  // click counter

            tapGesture.Tapped += (s, e) =>
            {
                count++;
                label.Text = $"Clicked {count} times";
            };

            label.GestureRecognizers.Add(tapGesture);

            grid.Children.Add(label);

            Content = grid;
        }
    }
}
