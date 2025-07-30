namespace ImageApp
{
    public class StartPage5 : ContentPage
    {
        // Image Aspect example:
        public StartPage5()
        {
            Grid grid = new Grid { Padding = 2 };

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            var fileName = "forest.jpg";

            grid.Add(new Image { Source = fileName, Aspect = Aspect.AspectFit }, 0, 0);
            grid.Add(new Image { Source = fileName, Aspect = Aspect.AspectFill }, 1, 0);
            grid.Add(new Image { Source = fileName, Aspect = Aspect.Fill }, 0, 1);
            grid.Add(new Image { Source = fileName, Aspect = Aspect.Center }, 1, 1);

            Content = grid;
        }
    }
}
