namespace SwitchAndCheckBoxApp
{
    public class StartPage1 : ContentPage
    {
        Label label;

        // Switch example:
        public StartPage1()
        {
            Switch switcher = new Switch { IsToggled = true };

            switcher.Toggled += switcher_Toggled;

            label = new Label
            {
                FontSize = 16,
                Text = $"Value: {switcher.IsToggled}"
            };

            Content = new StackLayout { Children = { switcher, label }, Padding = 8 };
        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            label.Text = $"Value: {e.Value}";
        }
    }
}
