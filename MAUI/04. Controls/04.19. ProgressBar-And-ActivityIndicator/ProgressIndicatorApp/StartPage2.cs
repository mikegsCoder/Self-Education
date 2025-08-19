using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressIndicatorApp
{
    public class StartPage2 : ContentPage
    {
        ProgressBar progressBar = new ProgressBar { ProgressColor = Colors.SeaGreen };
        Label label = new Label();

        // ProgressBar example:
        public StartPage2()
        {
            StackLayout stackLayout = new StackLayout { Padding = 20 };

            stackLayout.Children.Add(label);
            stackLayout.Children.Add(progressBar);

            Content = stackLayout;
        }

        protected override async void OnAppearing()
        {
            while (progressBar.Progress < 0.9)
            {
                progressBar.Progress += 0.1;

                label.Text = $"Progress value: {Math.Round(progressBar.Progress, 1) * 100} %";
                
                await Task.Delay(1000);
            }

            label.Text = "Progress finished!";

            base.OnAppearing();
        }
    }
}
