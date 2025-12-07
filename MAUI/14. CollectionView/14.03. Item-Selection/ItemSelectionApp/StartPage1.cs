namespace ItemSelectionApp
{
    public class StartPage1 : ContentPage
    {
        // SelectedItem example:
        public StartPage1()
        {
            CollectionView collectionView = new CollectionView { VerticalOptions = LayoutOptions.Start };

            // set SelectionMode:
            collectionView.SelectionMode = SelectionMode.Single;
            
            // set data source:
            collectionView.ItemsSource = new List<Person>
            {
                new  Person { Name="Tom", Company ="Microsoft" },
                new  Person { Name="Sam", Company ="Google" },
                new  Person { Name="Bob", Company ="JetBrains" },
                new  Person { Name="Alice", Company ="Microsoft" },
                new  Person { Name="Kate", Company ="Google" },
                new  Person { Name="Amelia", Company ="JetBrains" }
            };

            // set data template:
            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Color.FromArgb("#006064") };
                nameLabel.SetBinding(Label.TextProperty, "Name");

                var companyLabel = new Label();
                companyLabel.SetBinding(Label.TextProperty, "Company");

                return new StackLayout
                {
                    Children = { nameLabel, companyLabel },
                    Margin = 8
                };
            });

            // label for the selected item:
            Label selectedLabel = new Label { Margin = 8, FontSize = 18 };
            selectedLabel.SetBinding(Label.TextProperty,
                new Binding { Source = collectionView, Path = "SelectedItem.Name", StringFormat = "Selected: {0}" });
            
            Content = new StackLayout { selectedLabel, collectionView };
        }
    }
}
