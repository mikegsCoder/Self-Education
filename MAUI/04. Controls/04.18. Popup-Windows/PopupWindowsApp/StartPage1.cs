using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupWindowsApp
{
    public class StartPage1 : ContentPage
    {
        // DisplayAlert example:
        public StartPage1()
        {
            Button alertButton = new Button
            {
                Text = "Alert",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };

            alertButton.Clicked += AlertButton_Clicked;

            Content = alertButton;
        }

        private async void AlertButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Information", "New message arrived", "ОK");
        }
    }
}
