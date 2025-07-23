using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxViewApp
{
    public class StartPage2 : ContentPage
    {
        // BoxView example:
        public StartPage2()
        {
            Label label1 = new Label
            {
                Text = ".NET MAUI",
                FontSize = 22,
                HorizontalOptions = LayoutOptions.Center
            };

            Label label2 = new Label
            {
                Text = "Multiplatform Application User Interface",
                FontSize = 18,
                HorizontalOptions = LayoutOptions.Center
            };

            BoxView boxView1 = new BoxView
            {
                Color = Colors.Gray,
                HeightRequest = 2,
                Margin = new Thickness(1),
                HorizontalOptions = LayoutOptions.Fill
            };

            BoxView boxView2 = new BoxView
            {
                Color = Colors.Gray,
                HeightRequest = 2,
                Margin = 1,
                HorizontalOptions = LayoutOptions.Fill
            };

            StackLayout stackLayout = new StackLayout
            {
                Children = { label1, boxView1, boxView2, label2 },
                Margin = new Thickness(20),
            };

            Content = stackLayout;
        }
    }
}
