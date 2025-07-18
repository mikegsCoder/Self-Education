namespace LabelApp
{
    public class StartPage3 : ContentPage
    {
        //Multi line text example:
        public StartPage3()
        {
            Grid grid = new Grid();

            Label header = new Label();

            header.Text = "First line,\n" +
                "Second line,\n" +
                "Third line,\n" +
                "Fourth line.\n";

            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;
            header.FontSize = 22;

            grid.Children.Add(header);

            Content = grid;
        }
    }
}
