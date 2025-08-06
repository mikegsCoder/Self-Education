namespace StepperAndSliderApp
{
    public class StartPage2 : ContentPage
    {
        Label header;

        // Slider example:
        public StartPage2()
        {
            header = new Label { FontSize = 18, Margin = 5 };

            Slider slider = new Slider
            {
                Maximum = 50,
                Minimum = 0,
                Value = 30,
                ThumbColor = Colors.DeepPink,
                MinimumTrackColor = Colors.DeepPink,
                MaximumTrackColor = Colors.LightPink
            };

            slider.ValueChanged += OnSliderValueChanged;

            Content = new StackLayout { Children = { header, slider }, Padding = 20 };
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            header.Text = $"Your choice is: {e.NewValue:F1}";
        }
    }
}
