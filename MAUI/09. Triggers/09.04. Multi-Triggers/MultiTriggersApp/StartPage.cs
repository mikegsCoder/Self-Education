namespace MultiTriggersApp
{
    public class StartPage : ContentPage
    {
        //MultiTrigger example:
        public StartPage()
        {
            Entry email = new Entry { Text = "", Margin = 10 };
            Entry phone = new Entry { Text = "", Margin = 10 };

            Button button = new Button
            {
                BackgroundColor = Color.FromArgb("#fff"),
                TextColor = Color.FromArgb("#01579B"),
                Text = "Save",
                Margin = 10
            };

            // Create MultiTrigger:
            MultiTrigger multiTrigger = new MultiTrigger(typeof(Button));
            
            // Add conditions:
            multiTrigger.Conditions.Add(new BindingCondition { Binding = new Binding { Source = email, Path = "Text.Length" }, Value = 0 });
            multiTrigger.Conditions.Add(new BindingCondition { Binding = new Binding { Source = phone, Path = "Text.Length" }, Value = 0 });
            
            // Add setters:
            multiTrigger.Setters.Add(new Setter { Property = Button.BackgroundColorProperty, Value = Colors.LightGray });
            multiTrigger.Setters.Add(new Setter { Property = Button.TextColorProperty, Value = Colors.Gray });
            multiTrigger.Setters.Add(new Setter { Property = Button.IsEnabledProperty, Value = false });
            
            // Add trigger to the button:
            button.Triggers.Add(multiTrigger);
            
            Content = new StackLayout
            {
                Padding = 10,
                Children = { email, phone, button }
            };
        }
    }
}
