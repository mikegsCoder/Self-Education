using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTriggersApp
{
    //Event trigger example:
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            Entry entry = new Entry();

            var trigger = new EventTrigger()
            {
                Event = "TextChanged"
            };

            trigger.Actions.Add(new EntryValidation());
            entry.Triggers.Add(trigger);

            Content = new StackLayout
            {
                Children = { entry }
            };
        }
    }
}
