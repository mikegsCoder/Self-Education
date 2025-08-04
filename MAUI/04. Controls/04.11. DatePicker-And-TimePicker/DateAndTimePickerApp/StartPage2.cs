namespace DateAndTimePickerApp
{
    public class StartPage2 : ContentPage
    {
        Label label;
        TimePicker timePicker;

        // TimePicker example:
        public StartPage2()
        {
            label = new Label 
            { 
                Text = "Choose time", 
                FontSize = 20 
            };

            timePicker = new TimePicker() { Time = new TimeSpan(17, 0, 0) };
            timePicker.PropertyChanged += TimePicker_PropertyChanged;

            StackLayout stack = new StackLayout 
            { 
                Children = { label, timePicker }, 
                Padding = 20 
            };
            
            Content = stack;
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                label.Text = $"Your choice is: {timePicker.Time}.";
            }
        }
    }
}
