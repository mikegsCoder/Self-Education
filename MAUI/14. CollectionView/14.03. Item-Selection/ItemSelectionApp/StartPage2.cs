using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemSelectionApp
{
    public class StartPage2 : ContentPage
    {
        // SelectedItem example:
        public StartPage2()
        {
            var people = new List<Person>
            {
                new  Person { Name="Tom", Company ="Microsoft" },
                new  Person { Name="Sam", Company ="Google" },
                new  Person { Name="Bob", Company ="JetBrains" },
                new  Person { Name="Alice", Company ="Microsoft" },
                new  Person { Name="Kate", Company ="Google" },
                new  Person { Name="Amelia", Company ="JetBrains" }
            };

            CollectionView collectionView = new CollectionView { VerticalOptions = LayoutOptions.Start };
            
            // set selection mode:
            collectionView.SelectionMode = SelectionMode.Single;
            
            // set data source:
            collectionView.ItemsSource = people;

            // select second element:
            collectionView.SelectedItem = people[1];

            // set data template:
            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Color.FromArgb("#006064") };
                nameLabel.SetBinding(Label.TextProperty, "Name");
                
                var companyLabel = new Label();
                companyLabel.SetBinding(Label.TextProperty, "Company");
                
                return new StackLayout { Children = { nameLabel, companyLabel }, Padding = 10 };
            });

            Content = collectionView;
        }
    }
}
