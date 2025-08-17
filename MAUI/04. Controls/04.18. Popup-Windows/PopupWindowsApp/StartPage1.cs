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

        //private async void AlertButton_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Information", "New message arrived", "ОK");
        //}

        private async void AlertButton_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Confirmation", "Are you sure you want to delete this element?", "Yes", "No");

            await DisplayAlert("Information", "Your choice is: " + (result ? "Delete" : "Cancel"), "OK");
        }
    }
}
