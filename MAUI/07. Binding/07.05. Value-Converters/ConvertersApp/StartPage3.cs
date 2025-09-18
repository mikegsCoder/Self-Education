using ConvertersApp.Converters;

namespace ConvertersApp
{
    public class StartPage3 : ContentPage
    {
        //Object Binding custom conversion example:
        public StartPage3()
        {
            Label label = new Label();
            DatePicker datePicker = new DatePicker();

            Binding binding = new Binding { Source = datePicker, Path = "Date", Converter = new DateTimeToLocalDateConverter() };
            label.SetBinding(Label.TextProperty, binding);
            
            StackLayout stackLayout = new StackLayout()
            {
                Children = { label, datePicker },
                Padding = 20
            };
            
            Content = stackLayout;
        }
    }
}
