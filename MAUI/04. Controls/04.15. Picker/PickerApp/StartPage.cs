using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickerApp
{
    public class StartPage : ContentPage
    {
        Label header = new Label { Text = "Choose a technology:", FontSize = 18 };
        Picker languagePicker = new Picker 
        { 
            Title = "Programming technology" ,
            WidthRequest = 250,
            HorizontalOptions = LayoutOptions.Start
        };

        // Picker example:
        public StartPage()
        {
            // dynamically add elements:
            languagePicker.Items.Add("C#");
            languagePicker.Items.Add("JavaScript");
            languagePicker.Items.Add("TypeScript");

            // explicitly set elements:
            // languagePicker.ItemsSource = new string[]{ "C#", "JavaScript", "TypeScript"};

            // set index:
            // languagePicker.SelectedIndex = 0;

            languagePicker.SelectedIndexChanged += PickerSelectedIndexChanged;

            Content = new StackLayout { Children = { header, languagePicker }, Padding = 8 };
        }

        void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = $"Your choice is: {languagePicker.SelectedItem}";

            // using index:
            //header.Text = $"Your choice is: {languagePicker.Items[languagePicker.SelectedIndex]}";
        }
    }
}
