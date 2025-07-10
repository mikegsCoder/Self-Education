using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStylingApp
{
    public class StartPage3 : ContentPage
    {
        public StartPage3()
        {
            // FontAttributes example:
            Label label1 = new Label
            {
                Text = "Bold",
                FontAttributes = FontAttributes.Bold
            };

            Label label2 = new Label
            {
                Text = "Bold and Italics",
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            StackLayout layout = new StackLayout() { label1, label2 };

            Content = layout;
        }
    }
}
