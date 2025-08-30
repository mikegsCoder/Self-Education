using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesApp
{
    public class StartPage2 : ContentPage
    {
        //Dynamic resources example:
        public StartPage2()
        {
            ResourceDictionary resDict = new ResourceDictionary();
            // add resource into ResourceDictionary:
            resDict.Add("textColor", Color.FromArgb("#1976D2"));

            // set ResourceDictionary:
            this.Resources = resDict;

            Button androidButton = new Button
            {
                Text = "Change",
                WidthRequest = 120,
                BackgroundColor = Colors.White
            };

            // set dynamic resource:
            androidButton.SetDynamicResource(Button.TextColorProperty, "textColor");
            androidButton.Clicked += ColorChange;

            Content = new StackLayout
            {
                Padding = 20,
                Children = { androidButton }
            };
        }

        private void ColorChange(object sender, EventArgs e)
        {
            Color textColor = (Color)Resources["textColor"];

            Resources["textColor"] = textColor.ToHex() == "#1976D2" 
                ? Color.FromArgb("#00838F") 
                : Color.FromArgb("#1976D2");
        }
    }
}
