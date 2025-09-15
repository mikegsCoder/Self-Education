using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatBindingApp
{
    public class StartPage2 : ContentPage
    {
        //Binding object StringFormat example:
        public StartPage2()
        {
            Entry entry = new Entry();
            Label label = new Label();

            Binding binding = new Binding { Source = entry, Path = "Text", StringFormat = "Message: {0}" };
            label.SetBinding(Label.TextProperty, binding);
            
            StackLayout stackLayout = new StackLayout()
            {
                Children = { entry, label },
                Padding = 20
            };
            
            Content = stackLayout;
        }
    }
}
