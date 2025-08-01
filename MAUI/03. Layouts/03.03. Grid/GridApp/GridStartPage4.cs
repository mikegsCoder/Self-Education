﻿namespace GridApp
{
    public class GridStartPage4 : ContentPage
    {
        public GridStartPage4()
        {
            // Grid example with spacing:
            var grid = new Grid
            {
                ColumnSpacing = 5,
                RowSpacing = 8,
                RowDefinitions =
                {
                    new RowDefinition{ Height=new GridLength(1, GridUnitType.Star) },
                    new RowDefinition{ Height=new GridLength(2, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(2, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)}
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
