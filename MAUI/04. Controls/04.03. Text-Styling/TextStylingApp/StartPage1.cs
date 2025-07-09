using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStylingApp
{
    public class StartPage1 : ContentPage
    {
        public StartPage1()
        {
            // text styling example:
            Label header = new Label() { Text = ".NET MAUI in Arial" };
            header.FontFamily = "Arial";

            Content = header;
        }
    }
}
