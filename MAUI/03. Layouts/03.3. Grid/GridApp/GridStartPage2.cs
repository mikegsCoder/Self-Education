using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridApp
{
    public class GridStartPage2 : ContentPage
    {
        public GridStartPage2()
        {
            // Grid example with defining size:
            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{ Height=new GridLength(120) },
                    new RowDefinition()
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width = new GridLength(100)},
                    new ColumnDefinition(),
                    new ColumnDefinition{Width = new GridLength(100)},
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
