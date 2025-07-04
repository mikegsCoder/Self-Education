using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeAndPositioningApp
{
    public class StartPage5 : ContentPage
    {
        public StartPage5()
        {
            // horizontal and vertical alignment example:
            Label header = new Label() { Text = "Hello from MAUI!" };
            header.VerticalOptions = LayoutOptions.Center;
            header.HorizontalOptions = LayoutOptions.Center;

            Content = header;
        }
    }
}
