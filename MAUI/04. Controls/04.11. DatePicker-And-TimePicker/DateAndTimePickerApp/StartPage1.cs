using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimePickerApp
{
    public class StartPage1 : ContentPage
    {
        Label label;

        // DatePicker example:
        public StartPage1()
        {
            label = new Label { Text = "Choose date" };

            DatePicker datePicker = new DatePicker
            {
                Format = "d",
                MaximumDate = DateTime.Now.AddDays(5),
                MinimumDate = DateTime.Now.AddDays(-5)
            };

            datePicker.DateSelected += DateSelected;

            StackLayout stack = new StackLayout 
            { 
                Children = { label, datePicker }, 
                Padding = 20 
            };
            
            Content = stack;
        }

        void DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text = $"Your choice is: {e.NewDate.ToString("d")}";
        }
    }
}
