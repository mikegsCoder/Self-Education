namespace DataTemplateApp
{
    public class StartPage3 : ContentPage
    {
        public List<User> Users { get; set; } = new();
        Label selectedItemHeader = new Label { FontSize = 18 };
        Label tappedItemHeader = new Label { FontSize = 18 };

        // ItemTapped and ItemSelected example:
        public StartPage3()
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

            usersListView.ItemSelected += UsersListView_ItemSelected;
            usersListView.ItemTapped += UsersListView_ItemTapped;

            Content = new StackLayout 
            { 
                Children = { selectedItemHeader, tappedItemHeader, usersListView }, 
                Padding = 7 
            };
        }

        private void UsersListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tappedUser = e.Item as User;

            if (tappedUser != null)
            {
                tappedItemHeader.Text = $"Clicked: {tappedUser.Name}";
            }
        }

        private void UsersListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedUser = e.SelectedItem as User;

            if (selectedUser != null)
            {
                selectedItemHeader.Text = $"Selected: {selectedUser.Name}";
            }
        }
    }
}
