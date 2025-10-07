using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTriggersApp
{
    public class EntryValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (!int.TryParse(sender.Text, out int number))
            { 
                sender.TextColor = Colors.Red;
            }
            else
            {
                sender.TextColor = Colors.Green;
            }
        }
    }
}
