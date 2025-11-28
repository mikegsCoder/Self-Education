using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewApp
{
    public class StartPage3 : ContentPage
    {
        // CollectionView example:
        public StartPage3()
        {
            CollectionView collectionView = new CollectionView();
            
            // set data source:
            collectionView.ItemsSource = new List<Person>
            {
                new  Person { Name="Tom", Age=38, Company ="Microsoft" },
                new  Person { Name="Sam", Age=25,  Company ="Google" },
                new  Person { Name="Bob", Age=42,  Company ="JetBrains" },
                new  Person { Name="Alice", Age=33,  Company ="Microsoft" },
                new  Person { Name="Kate", Age=29,  Company ="Google" },
                new  Person { Name="Amelia", Age=35,  Company ="JetBrains" },
            };

            // set data template:
            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Color.FromArgb("#006064"), Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, "Name");

                var ageLabel = new Label();
                ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "Age", StringFormat = "Age: {0}" });

                var companyLabel = new Label();
                companyLabel.SetBinding(Label.TextProperty, "Company");

                return new StackLayout
                {
                    Children = { nameLabel, ageLabel, companyLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            Content = collectionView;
        }
    }
}
