using System.Collections.ObjectModel;

namespace ObservableCollectionApp
{
    public class StartPage : ContentPage
    {
        public ObservableCollection<User> Users { get; set; }
        Entry nameEntry, ageEntry;

        // ObservableCollection example:
        public StartPage()
        {
            // set data:
            Users = new ObservableCollection<User>
            {
                new User {Name="Tom", Age=38 },
                new User {Name = "Bob", Age = 42}
            };

            ListView listView = new ListView();

            // set data source:
            listView.ItemsSource = Users;

            // set data template:
            listView.ItemTemplate = new DataTemplate(() =>
            {
                // property Name binding:
                Label nameLabel = new Label { FontSize = 16 };
                nameLabel.SetBinding(Label.TextProperty, "Name");

                // property Age binding:
                Label ageLabel = new Label { FontSize = 14 };
                ageLabel.SetBinding(Label.TextProperty, "Age");

                // create ViewCell onject:
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

            // Entries for adding new User:
            nameEntry = new Entry { Placeholder = "Enter name", Margin = 5 };
            ageEntry = new Entry { Placeholder = "Enter age", Margin = 5 };
            
            Button saveButton = new Button { Text = "Save", WidthRequest = 100, Margin = 5, HorizontalOptions = LayoutOptions.Start };
            saveButton.Clicked += SaveButton_Clicked;
            
            StackLayout form = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { nameEntry, ageEntry, saveButton }
            };

            Content = new StackLayout 
            { 
                Children = { form, listView }, 
                Padding = 7 
            };
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            int.TryParse(ageEntry.Text, out var age);

            Users.Add(new User { Name = nameEntry.Text, Age = age });

            nameEntry.Text = ageEntry.Text = "";
        }
    }
}
