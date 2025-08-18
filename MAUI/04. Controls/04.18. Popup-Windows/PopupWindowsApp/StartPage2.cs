namespace PopupWindowsApp
{
    public class StartPage2 : ContentPage
    {
        Label actionLabel;

        // DisplayActionSheet example:
        public StartPage2()
        {
            Button alertButton = new Button { Text = "Alert", HorizontalOptions = LayoutOptions.Center };
            
            alertButton.Clicked += AlertButton_Clicked;
            
            actionLabel = new Label();

            Content = new StackLayout { Children = { alertButton, actionLabel } };
        }

        private async void AlertButton_Clicked(object sender, EventArgs e)
        {
            //var action = await DisplayActionSheet("Choose Technology", "Cancel", "Ok", "C#", "JavaScript", "TypeScript");
            var action = await DisplayActionSheet("Choose Technology", "Cancel", null, "C#", "JavaScript", "TypeScript");
            
            actionLabel.Text = action;
        }
    }
}
