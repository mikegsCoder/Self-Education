namespace TextFieldsApp
{
    public class StartPage3 : ContentPage
    {
        // Editor example:
        public StartPage3()
        {
            StackLayout stackLayout = new StackLayout();

            Editor textEditor = new Editor { HeightRequest = 200, FontSize = 16 };
            
            stackLayout.Children.Add(textEditor);

            Content = stackLayout;
        }
    }
}
