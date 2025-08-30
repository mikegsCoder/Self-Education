namespace ResourcesApp
{
    public class StartPage1 : ContentPage
    {
        //ResourcesApp example:
        public StartPage1()
        {
            Color textColor = Color.FromArgb("#004D40");
            Color backColor = Color.FromArgb("#80CBC4");
            int margin = 10;

            // create ResourceDictionary:
            ResourceDictionary resDict = new ResourceDictionary();

            // add resources:
            resDict.Add("textColor", textColor);
            resDict.Add("backColor", backColor);
            resDict.Add("margin", margin);

            // set ResourceDictionary for current page:
            this.Resources = resDict;

            Button iosButton = new Button { Text = "iOS" };
            // get resource from ResourceDictionary:
            iosButton.TextColor = (Color)Resources["textColor"];
            iosButton.BackgroundColor = (Color)Resources["backColor"];
            iosButton.Margin = (int)Resources["margin"];

            Button androidButton = new Button { Text = "Android" };
            androidButton.TextColor = (Color)Resources["textColor"];
            androidButton.BackgroundColor = (Color)Resources["backColor"];
            androidButton.Margin = (int)Resources["margin"];

            Content = new StackLayout
            {
                Padding = 10,
                Children = { iosButton, androidButton }
            };
        }
    }
}
