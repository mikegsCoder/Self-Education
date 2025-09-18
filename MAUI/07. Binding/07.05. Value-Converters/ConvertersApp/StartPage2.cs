using ConvertersApp.Converters;

namespace ConvertersApp
{
    public class StartPage2 : ContentPage
    {
        //Custom conversion example:
        public StartPage2()
        {
            Label label = new Label();
            DatePicker datePicker = new DatePicker();

            label.BindingContext = datePicker;
            label.SetBinding(Label.TextProperty, "Date", converter: new DateTimeToLocalDateConverter());
            
            StackLayout stackLayout = new StackLayout()
            {
                Children = { label, datePicker },
                Padding = 20
            };
            
            Content = stackLayout;
        }
    }
}
