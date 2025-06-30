namespace GridApp
{
    public class GridStartPage1 : ContentPage
    {
        public GridStartPage1()
        {
            // Grid example:
            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition(),
                    new RowDefinition()
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition()
                }
            };

            grid.Add(new BoxView { Color = Colors.Red }, 0, 0);
            grid.Add(new BoxView { Color = Colors.Blue }, 0, 1);

            grid.Add(new BoxView { Color = Colors.Teal }, 1, 0);
            grid.Add(new BoxView { Color = Colors.Green }, 1, 1);

            grid.Add(new BoxView { Color = Colors.Olive }, 2, 0);
            grid.Add(new BoxView { Color = Colors.Pink }, 2, 1);

            Content = grid;
        }
    }
}
