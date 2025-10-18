using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewApp
{
    public class StartPage2 : ContentPage
    {
        // Binding to SelectedItem example:
        public StartPage2()
        {
            Label header = new Label();

            ListView usersList = new ListView();

            // Set data source:
            usersList.ItemsSource = new string[] 
            { 
                "Tomas", 
                "Bob", 
                "Sam", 
                "Alice" 
            };
            
            // SetBinding:
            header.SetBinding(Label.TextProperty, new Binding { Source = usersList, Path = "SelectedItem" });
            
            Content = new StackLayout 
            { 
                Children = { header, usersList }, 
                Padding = 7 
            };
        }
    }
}
