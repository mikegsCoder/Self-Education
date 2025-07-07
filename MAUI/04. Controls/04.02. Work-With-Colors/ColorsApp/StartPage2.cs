namespace ColorsApp
{
    public class StartPage2 : ContentPage
    {
        public StartPage2()
        {
            // work with colors another example:
            Label header = new Label() { Text = "Hello from MAUI!" };
            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;

            header.BackgroundColor = new Color(178, 223, 219);  // background color
            header.TextColor = new Color(0, 77, 64);            // text color
            
            Content = header;
        }
    }
}
