using ConvertersApp.Converters;

namespace ConvertersApp
{
    public class StartPage4 : ContentPage
    {
        //Object Binding custom conversion example:
        public StartPage4()
        {
            Label label = new Label { Text = "Hello from MAUI!" };
            Entry entry = new Entry();

            Binding binding = new Binding { Source = entry, Path = "Text", Converter = new StringToColorConverter() };
            label.SetBinding(Label.TextColorProperty, binding);
            
            StackLayout stackLayout = new StackLayout()
            {
                Children = { entry, label },
                Padding = 20
            };
            
            Content = stackLayout;
        }
    }
}
