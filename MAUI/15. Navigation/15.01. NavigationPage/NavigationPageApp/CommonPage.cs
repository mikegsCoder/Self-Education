using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationPageApp
{
    public class CommonPage : ContentPage
    {
        public CommonPage()
        {
            Title = "Common";

            Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
            
            Label label = new Label { Text = "Lorem Ipsum is simply dummy text of the printing..." };
            
            // Back navigation:
            backButton.Clicked += async (o, e) => await Navigation.PopAsync();
            
            Content = new StackLayout { Children = { label, backButton } };
        }
    }
}
