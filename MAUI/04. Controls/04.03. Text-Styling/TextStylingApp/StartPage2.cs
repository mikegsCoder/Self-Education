namespace TextStylingApp
{
    public class StartPage2 : ContentPage
    {
        public StartPage2()
        {
            // FontSize example:
            Label header = new Label() { Text = ".NET MAUI" };
            header.FontSize = 26;

            Content = header;
        }
    }
}
