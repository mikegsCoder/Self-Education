﻿//using Xamarin.Forms;

namespace HelloApp
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}