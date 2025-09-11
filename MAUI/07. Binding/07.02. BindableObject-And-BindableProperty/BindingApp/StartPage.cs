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
