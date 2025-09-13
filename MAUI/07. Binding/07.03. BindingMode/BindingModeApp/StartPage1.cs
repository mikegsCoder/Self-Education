namespace BindingModeApp
{
    public class StartPage1 : ContentPage
    {
        // BindingContext TwoWay binding mode example:
        public StartPage1()
        {
            Entry entry1 = new Entry { Margin = 10 };
            Entry entry2 = new Entry { Margin = 10 };

            entry2.BindingContext = entry1;

            entry2.SetBinding(Entry.TextProperty, "Text", BindingMode.TwoWay);
            
            StackLayout stackLayout = new StackLayout()
            {
                Children = { entry1, entry2 },
                Padding = 10
            };

            Content = stackLayout;
        }
    }
}
