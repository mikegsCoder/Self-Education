using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateApp
{
    public class StartPage2 : ContentPage
    {
        public List<User> Users { get; set; } = new();

        // DataTemplate example:
        public StartPage2()
        {
            // set data:
            Users = new List<User>
            {
                new User {Name="Tom", Age=38 },
                new User {Name = "Bob", Age= 42},
                new User {Name="Sam", Age = 28},
                new User {Name = "Alice", Age = 33}
            };

            ListView usersListView = new ListView();
            // set data source:
            usersListView.ItemsSource = Users;

            // set data template:
            usersListView.ItemTemplate = new DataTemplate(() =>
            {
                // property Name binding:
                Label nameLabel = new Label { FontSize = 16 };
                nameLabel.SetBinding(Label.TextProperty, "Name");

                // property Age binding:
                Label ageLabel = new Label { FontSize = 14 };
                ageLabel.SetBinding(Label.TextProperty, "Age");

                // create ViewCell:
                return new ViewCell
                {
                    View = new StackLayout
                    {
                        Padding = new Thickness(0, 5),
                        Orientation = StackOrientation.Vertical,
                        Children = { nameLabel, ageLabel }
                    }
                };
            });

            Label header = new Label { FontSize = 18 };

            // set binding:
            Binding userBinding = new Binding { StringFormat = "Selected: {0}", Path = "SelectedItem.Name", Source = usersListView };
            header.SetBinding(Label.TextProperty, userBinding);
            
            Content = new StackLayout 
            { 
                Children = { header, usersListView }, 
                Padding = 7 
            };
        }
    }
}
