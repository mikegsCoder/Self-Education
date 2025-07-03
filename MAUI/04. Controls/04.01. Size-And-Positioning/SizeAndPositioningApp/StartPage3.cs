using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeAndPositioningApp
{
    public class StartPage3 : ContentPage
    {
        public StartPage3()
        {
            // more margin and padding examples:
            var stackLayout = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
                Children = 
                {
                    new BoxView { Color = Colors.Green, Margin = new Thickness (20) },
                    new BoxView { Color = Colors.Blue, Margin = new Thickness (10, 25) },
                    new BoxView { Color = Colors.Red, Margin = new Thickness (0, 20, 15, 5) }
                }
            };

            Content = stackLayout;
        }
    }
}
