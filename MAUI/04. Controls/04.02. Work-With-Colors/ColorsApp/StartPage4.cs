using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsApp
{
    public class StartPage4 : ContentPage
    {
        public StartPage4()
        {
            // work with colors more examples:
            Label header = new Label() { Text = "Hello from MAUI!" };
            
            Color customColor = Colors.Teal;
            customColor = customColor.WithAlpha(0.5f);
            customColor = customColor.WithHue(0.5f);
            customColor = customColor.WithLuminosity(0.9f);

            header.BackgroundColor = customColor;

            Content = header;
        }
    }
}
