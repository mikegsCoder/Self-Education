using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTriggersApp
{
    public class StartPage : ContentPage
    {
        //Property Trigger example:
        public StartPage()
        {
            Entry entry = new Entry 
            { 
                Text = "Hello from MAUI!", 
                TextColor = Colors.LightGray 
            };

            // Create trigger for Entry:
            var trigger = new Trigger(typeof(Entry))
            {
                Property = IsFocusedProperty,
                Value = true
            };

            // Add Setter for TextColorProperty:
            trigger.Setters.Add(new Setter
            {
                Property = Entry.TextColorProperty,
                Value = Colors.Black
            });

            // Add Trigger to triggers collection:
            entry.Triggers.Add(trigger);

            Content = new StackLayout
            {
                Padding = 20,
                Children = { entry }
            };
        }
    }
}
