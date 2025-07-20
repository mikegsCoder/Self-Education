using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFieldsApp
{
    public class StartPage1 : ContentPage
    {
        // Entry example:
        public StartPage1()
        {
            StackLayout stackLayout = new StackLayout();

            Entry entry = new Entry
            {
                Placeholder = "Enter your email",
                FontFamily = "Helvetica",
                FontSize = 22,
                MaxLength = 20,
                Keyboard = Keyboard.Email
            };

            stackLayout.Children.Add(entry);

            Content = stackLayout;
        }
    }
}
