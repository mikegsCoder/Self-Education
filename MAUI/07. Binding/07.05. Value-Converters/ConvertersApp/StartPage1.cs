namespace ConvertersApp
{
    public class StartPage1 : ContentPage
    {
        //Default convesion example:
        public StartPage1()
        {
            Label label = new Label();
            DatePicker datePicker = new DatePicker();

            label.BindingContext = datePicker;
            label.SetBinding(Label.TextProperty, "Date");

            StackLayout stackLayout = new StackLayout()
            {
                Children = { label, datePicker },
                Padding = 20
            };

            Content = stackLayout;
        }
    }
}
