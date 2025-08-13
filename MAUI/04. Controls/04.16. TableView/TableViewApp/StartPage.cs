using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableViewApp
{
    public class StartPage : ContentPage
    {
        // TableView example:
        public StartPage()
        {
            TableView tableView = new TableView
            {
                Intent = TableIntent.Data,

                Root = new TableRoot("Software Develoment")
                {
                    new TableSection ("Programming languages")
                    {
                        new TextCell{ Text = "C#", Detail = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tristique id enim quis posuere. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas."},
                        new TextCell{ Text = "JavaScript", Detail = "Pellentesque condimentum in mauris vel tristique. Vivamus tincidunt justo justo, eu tincidunt purus accumsan vel. Nulla gravida maximus sagittis."}
                    },
                    new TableSection ("Databases")
                    {
                        new TextCell{ Text = "MS SQL Server", Detail = "Suspendisse posuere cursus lacus eu tempus. Phasellus tincidunt ipsum vel vestibulum pellentesque. Ut quis odio at augue mattis porttitor eget ac orci."},
                        new TextCell{ Text = "MongoDB", Detail = "Praesent rhoncus non ante vel eleifend. Vivamus in ligula porta, lacinia ligula imperdiet, viverra mauris. Nam euismod odio a auctor tempor."},
                    }
                }
            };

            Content = new StackLayout { Children = { tableView }, Padding = 10 };
        }
    }
}
