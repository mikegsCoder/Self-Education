namespace TextStylingApp
{
    public class StartPage5 : ContentPage
    {
        public StartPage5()
        {
            // text alignment example:
            Label header = new Label() { Text = "Hello from MAUI!" };
            
            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;

            Content = header;
        }
    }
}
