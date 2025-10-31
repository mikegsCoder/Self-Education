using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderAndFooterApp
{
    public class StartPage1 : ContentPage
    {
        // Header and Footer example:
        public StartPage1()
        {
            ListView listView = new ListView();

            listView.RowHeight = 25;
            listView.Header = "User list:";
            listView.Footer = "April 2025";

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
