namespace StylesApp
{
    public class StartPage : ContentPage
    {
        //Styles example:
        public StartPage()
        {
            Style buttonStyle = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter
                    {
                        Property = Button.TextColorProperty,
                        Value = Color.FromArgb("#004D40")
                    },
                    new Setter
                    {
                        Property = Button.BackgroundColorProperty,
                        Value = Color.FromArgb("#80CBC4")
                    },
                    new Setter
                    {
                        Property = Button.MarginProperty,
                        Value = 10
                    }
                }
            };

            Button button1 = new Button { Text = "iOS", Style = buttonStyle };
            Button button2 = new Button { Text = "Android", Style = buttonStyle };

            Content = new StackLayout
            {
                Padding = 20,
                Children = { button1, button2 }
            };
        }
    }
}
