using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationStackApp
{
    public class Page2 : ContentPage
    {
        Label stackLabel;
        public Page2()
        {
            Title = "Page 2";
            Button forwardBtn = new Button { Text = "Forward" };
            forwardBtn.Clicked += GoToForward;

            Button backBtn = new Button { Text = "Back" };
            backBtn.Clicked += GoToBack;

            stackLabel = new Label();
            Content = new StackLayout { Children = { forwardBtn, backBtn, stackLabel } };
        }

        protected internal void DisplayStack()
        {
            if (Application.Current?.MainPage is NavigationPage navPage)
            {
                // show navigation stack:
                stackLabel.Text = "";

                foreach (Page p in navPage.Navigation.NavigationStack)
                {
                    stackLabel.Text = $"{p.Title}\n{stackLabel.Text}";
                }
            }
        }

        // Go to Page3
        private async void GoToForward(object? sender, EventArgs e)
        {
            Page3 page = new Page3();

            await Navigation.PushAsync(page);

            page.DisplayStack();    // calling DisplayStack from Page3
        }

        // Go back to MainPage
        private async void GoToBack(object? sender, EventArgs e)
        {
            await Navigation.PopAsync();

            if (Application.Current?.MainPage is NavigationPage navPage)
            {
                if (navPage.CurrentPage is MainPage mainPage)
                {
                    mainPage.DisplayStack();
                }
            }
        }
    }
}
