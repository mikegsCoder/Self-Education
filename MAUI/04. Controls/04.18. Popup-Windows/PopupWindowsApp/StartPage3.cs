namespace PopupWindowsApp
{
    public class StartPage3 : ContentPage
    {
        Label nameLabel;

        // DisplayPromptAsync example:
        public StartPage3()
        {
            Button alertButton = new Button { Text = "Alert", HorizontalOptions = LayoutOptions.Center };
            
            alertButton.Clicked += AlertButton_Clicked;
            
            nameLabel = new Label();
            
            Content = new StackLayout { Children = { alertButton, nameLabel } };
        }

        private async void AlertButton_Clicked(object sender, EventArgs e)
        {
            var name = await DisplayPromptAsync("Login", "Enter username:", "OK", "Cancel");
            
            nameLabel.Text = name;
        }
    }
}
