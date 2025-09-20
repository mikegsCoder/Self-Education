using ConverterParametersApp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterParametersApp
{
    public class StartPage : ContentPage
    {
        //Converter parameter example:
        public StartPage()
        {
            Entry entry = new Entry();
            Label euroLabel = new Label();
            Label dollarLabel = new Label();

            Binding euroBinding = new Binding
            {
                Source = entry,
                Path = "Text",
                Converter = new StringToCurrencyConverter(),
                ConverterParameter = "euro"
            };

            Binding dollarBinding = new Binding
            {
                Source = entry,
                Path = "Text",
                Converter = new StringToCurrencyConverter(),
                ConverterParameter = "dollar"
            };

            euroLabel.SetBinding(Label.TextProperty, euroBinding);
            dollarLabel.SetBinding(Label.TextProperty, dollarBinding);

            StackLayout stackLayout = new StackLayout()
            {
                Children = { entry, euroLabel, dollarLabel },
                Padding = 20
            };

            Content = stackLayout;
        }
    }
}
