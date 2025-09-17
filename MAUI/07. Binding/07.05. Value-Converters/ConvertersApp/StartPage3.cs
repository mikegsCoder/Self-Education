using ConvertersApp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
