using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCellApp
{
    public class StartPage : ContentPage
    {
        // TextCell example:
        public StartPage()
        {
            ListView usersListView = new ListView();

            // set data source:
            usersListView.ItemsSource = new List<User>
            {
                new User {Name="Tom", Age=38 },
                new User {Name = "Bob", Age= 40},
                new User {Name="Sam", Age = 28},
                new User {Name = "Alice", Age = 35}
            };

            // set data template:
            usersListView.ItemTemplate = new DataTemplate(() =>
            {
                // create TextCell object:
                TextCell textCell = new TextCell
                {
                    TextColor = Color.FromArgb("#01579B"),
                    DetailColor = Color.FromArgb("#0288D1")
                };

                // binding property Name:
                textCell.SetBinding(TextCell.TextProperty, "Name");

                // binding property Age:
                Binding ageBinding = new Binding { Path = "Age", StringFormat = "{0} years old" };
                
                textCell.SetBinding(TextCell.DetailProperty, ageBinding);
                
                return textCell;
            });

            Label header = new Label { FontSize = 18, Text = "User list:" };
            
            Content = new StackLayout 
            { 
                Children = { header, usersListView }, 
                Padding = 7 
            };
        }
    }
}
