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
