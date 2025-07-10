using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStylingApp
{
    public class StartPage4 : ContentPage
    {
        public StartPage4()
        {
            // fonts example:
            Label label = new Label
            {
                Text = "OpenSansSemibold",
                FontSize = 22,
                FontFamily = "OpenSansSemibold" 
            };

            Content = label;
        }
    }
}
