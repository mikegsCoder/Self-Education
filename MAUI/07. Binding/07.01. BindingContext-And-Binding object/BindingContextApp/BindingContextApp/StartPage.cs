using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingContextApp
{
    public class StartPage : ContentPage
    {
        //Binding context examle:
        public StartPage()
        {
            Label label = new Label();
            Entry entry = new Entry();

            // binding source - entry, binding target - label:
            label.BindingContext = entry;
            label.SetBinding(Label.TextProperty, "Text");

            StackLayout stackLayout = new StackLayout
            {
                Children = { label, entry },
                Padding = 20
            };

            Content = stackLayout;
        }
    }
}
