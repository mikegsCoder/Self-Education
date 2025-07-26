namespace ScrollViewApp
{
    public class StartPage3 : ContentPage
    {
        // ScrollView example:
        public StartPage3()
        {
            Grid grid = new Grid { Padding = new Thickness(20, 20, 0, 0) };
            
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            Label headerLabel = new Label { Text = "ScrollView example", FontSize = 22 };
            
            Label textLabel = new Label
            {
                FontSize = 18,
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam dolor neque, cursus vitae orci eu, viverra viverra dolor. Aliquam augue ex, egestas ut eros et, condimentum commodo ex. Quisque commodo sem elit, sit amet imperdiet diam eleifend sed. Quisque luctus faucibus odio sit amet interdum. Duis vel urna odio. Etiam eu euismod quam. Cras massa ex, facilisis ac sem vestibulum, efficitur efficitur nulla. Mauris nec turpis dui. Nullam pellentesque nulla at velit varius consequat.\r\n\r\nEtiam accumsan tortor nulla, ac ultrices magna sagittis id. Nullam sed libero egestas, imperdiet magna et, maximus nunc. Nulla facilisi. Morbi eros mi, iaculis ut dolor nec, posuere pharetra est. Quisque ut dapibus enim. Sed mattis porttitor consequat. Ut dictum nec felis id cursus. Nullam sagittis lobortis lobortis. Quisque orci neque, pretium vel interdum eget, consequat a ante. Vestibulum elementum nibh justo, vestibulum dictum ligula venenatis nec. Quisque tempus nisi imperdiet suscipit aliquet. Praesent fermentum felis non erat blandit, vitae rhoncus turpis condimentum. Nulla arcu odio, faucibus sed quam in, maximus dictum urna.\r\n\r\nUt id augue mauris. Morbi sodales est egestas aliquet egestas. Nunc pharetra ut tortor eget congue. Donec sit amet varius nulla, a tincidunt augue. Vestibulum sed ultricies mauris, a bibendum est. Proin iaculis turpis eu augue congue viverra. Maecenas imperdiet iaculis porttitor. Integer faucibus placerat felis, et viverra tortor gravida at. Nam erat ex, luctus quis condimentum in, tincidunt non libero. Nullam pretium lectus eget pellentesque vestibulum. Morbi pharetra tellus odio, ac viverra quam venenatis in. Curabitur euismod id sem id lacinia."
            };
            
            ScrollView scrollView = new ScrollView { Content = textLabel };
            
            grid.Add(headerLabel, row: 0);
            grid.Add(scrollView, row: 1);
            
            Content = grid;
        }
    }
}
