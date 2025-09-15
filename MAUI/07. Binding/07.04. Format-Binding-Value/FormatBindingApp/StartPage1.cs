using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatBindingApp
{
    public class StartPage1 : ContentPage
    {
        //SetBinding format example:
        public StartPage1()
        {
            Entry entry = new Entry();
            Label label = new Label();

            label.BindingContext = entry;
            label.SetBinding(Label.TextProperty, "Text", stringFormat: "Message: {0}");
            
            StackLayout stackLayout = new StackLayout()
            {
                Children = { entry, label },
                Padding = 20
            };

            Content = stackLayout;
        }
    }
}
