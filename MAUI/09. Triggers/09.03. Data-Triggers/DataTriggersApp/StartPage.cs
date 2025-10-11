namespace DataTriggersApp
{
    public class StartPage : ContentPage
    {
        //DataTrigger example:
        public StartPage()
        {
            Entry entry = new Entry { Text = "", Margin = 10 };
            Button button = new Button
            {
                BackgroundColor = Color.FromArgb("#fff"),
                TextColor = Color.FromArgb("#01579B"),
                Text = "Save",
                Margin = 10
            };

            // Create DataTrigger:
            DataTrigger dataTrigger = new DataTrigger(typeof(Button))
            {
                // Set binding:
                Binding = new Binding { Source = entry, Path = "Text.Length" },
                Value = 0
            };

            // Add setters:
            dataTrigger.Setters.Add(new Setter { Property = Button.BackgroundColorProperty, Value = Colors.LightGray });
            dataTrigger.Setters.Add(new Setter { Property = Button.TextColorProperty, Value = Colors.Gray });
            dataTrigger.Setters.Add(new Setter { Property = Button.IsEnabledProperty, Value = false });
            
            // Add trigger to the button:
            button.Triggers.Add(dataTrigger);

            Content = new StackLayout
            {
                Padding = 10,
                Children = { entry, button }
            };
        }
    }
}
