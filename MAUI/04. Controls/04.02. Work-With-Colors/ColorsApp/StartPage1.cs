using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsApp
{
    public class StartPage1 : ContentPage
    {
        public StartPage1()
        {
            // work with colors example:
            Label header = new Label() { Text = "Hello from MAUI!" };
            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;

            header.BackgroundColor = Colors.LightBlue;  // background color
            header.TextColor = Colors.DarkBlue;         // text color
            
            Content = header;
        }
    }
}
