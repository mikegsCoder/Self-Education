using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationStackApp
{
    public class Page3 : ContentPage
    {
        Label stackLabel;
        public Page3()
        {
            Title = "Page 3";
            Button backBtn = new Button { Text = "Back" };
            backBtn.Clicked += GoToBack;

            // label for navigation stack:
            stackLabel = new Label();
            Content = new StackLayout { Children = { backBtn, stackLabel } };
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

        // Go back to Page2:
        private async void GoToBack(object? sender, EventArgs e)
        {
            await Navigation.PopAsync();

            // get navigation page:
            if (Application.Current?.MainPage is NavigationPage navPage)
            {
                // get Page2 and call DisplayStack method:
                if (navPage.CurrentPage is Page2 page) page.DisplayStack();
            }
        }
    }
}
