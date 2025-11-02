using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderAndFooterApp
{
    public class StartPage2 : ContentPage
    {
        // Header and Footer example:
        public StartPage2()
        {
            ListView listView = new ListView();

            listView.RowHeight = 25;
            listView.Header = new Label { Text = "User list:", FontSize = 18 };
            listView.Footer = new HorizontalStackLayout
            {
                Children = 
                {
                    new Label { Text = ".NET MAUI", FontSize = 12, Margin = 10 },
                    new Label { Text = "April 2025", FontSize = 12, Margin = 10 },
                }
            };

            // set data source:
            listView.ItemsSource = new List<string>() { "Tom", "Sam", "Bob", "Alice" };
            
            Content = new StackLayout 
            { 
                Children = { listView }, 
                Padding = 7 
            };
        }
    }
}
