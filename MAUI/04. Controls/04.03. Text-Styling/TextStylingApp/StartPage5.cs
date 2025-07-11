using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStylingApp
{
    public class StartPage5 : ContentPage
    {
        public StartPage5()
        {
            // text alignment example:
            Label header = new Label() { Text = "Hello from MAUI!" };
            
            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;

            Content = header;
        }
    }
}
