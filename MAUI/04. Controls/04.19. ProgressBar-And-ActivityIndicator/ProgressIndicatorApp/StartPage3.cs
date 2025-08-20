using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressIndicatorApp
{
    public class StartPage3 : ContentPage
    {
        ActivityIndicator activityIndicator = new ActivityIndicator { IsRunning = true, Color = Colors.SeaGreen };
        Label label = new Label();

        // ActivityIndicator example:
        public StartPage3()
        {
            StackLayout stackLayout = new StackLayout { Padding = 20 };

            stackLayout.Children.Add(label);
            stackLayout.Children.Add(activityIndicator);

            Content = stackLayout;
        }

        protected override async void OnAppearing()
        {
            int count = 0;

            while (count != 100)
            {
                label.Text = $"Process value: {count} %";

                await Task.Delay(2000);

                count += 10;
            }

            label.Text = "Process finished!";
            activityIndicator.IsRunning = false;

            base.OnAppearing();
        }
    }
}
