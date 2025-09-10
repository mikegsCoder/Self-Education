namespace BindingObjectApp
{
    public class StartPage : ContentPage
    {
        //Binding object example:
        public StartPage()
        {
            Label label = new Label();
            Entry entry = new Entry();

            // creating binding object with source and path:
            Binding binding = new Binding { Source = entry, Path = "Text" };

            // set binding:
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
