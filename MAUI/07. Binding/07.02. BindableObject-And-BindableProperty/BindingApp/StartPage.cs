using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingApp
{
    public class StartPage : ContentPage
    {
        //Bindable property example:
        public StartPage()
        {
            TagLabel tagLabel = new TagLabel();
            Entry entry = new Entry();

            // binding source - entry, binding target - tagLabel:
            tagLabel.BindingContext = entry;
            // set binding:
            tagLabel.SetBinding(TagLabel.TagProperty, "Text");
            tagLabel.SetBinding(TagLabel.TextProperty, "Text");

            Label simpleLabel = new Label();

            simpleLabel.BindingContext = tagLabel;

            // set binding:
            simpleLabel.SetBinding(Label.TextProperty, "Tag");

            StackLayout stackLayout = new StackLayout()
            {
                Children = { tagLabel, entry, simpleLabel },
                Padding = 20
            };

            Content = stackLayout;
        }
    }
}
