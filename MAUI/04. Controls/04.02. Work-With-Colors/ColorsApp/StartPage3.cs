using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsApp
{
    public class StartPage3 : ContentPage
    {
        public StartPage3()
        {
            // work with colors FromArgb() example:
            Label header = new Label() { Text = "Hello from MAUI!" };
            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;

            header.BackgroundColor = Color.FromArgb("#B2DFDB");  // background color
            header.TextColor = Color.FromArgb("#aa004D40");      // text color
            
            Content = header;
        }
    }
}
