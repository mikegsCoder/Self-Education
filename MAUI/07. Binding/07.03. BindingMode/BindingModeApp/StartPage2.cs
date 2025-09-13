namespace BindingModeApp
{
    public class StartPage2 : ContentPage
    {
        // object Binding TwoWay binding mode example:
        public StartPage2()
        {
            Entry entry1 = new Entry { Margin = 10 };
            Entry entry2 = new Entry { Margin = 10 };

            // creating Binding object with Source, Path and Mode"
            Binding binding = new Binding { Source = entry1, Path = "Text", Mode = BindingMode.TwoWay };
            entry2.SetBinding(Entry.TextProperty, binding);
            
            StackLayout stackLayout = new StackLayout()
            {
                Children = { entry1, entry2 },
                Padding = 10
            };

            Content = stackLayout;
        }
    }
}
