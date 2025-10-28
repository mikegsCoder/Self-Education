using System.Collections.ObjectModel;

namespace ObservableCollectionApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<User> Users { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>
            {
                new User {Name="Tom", Age=38 },
                new User {Name = "Bob", Age = 42}
            };

            BindingContext = this; // binding current object
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            int.TryParse(ageEntry.Text, out var age);

            Users.Add(new User { Name = nameEntry.Text, Age = age });
            
            nameEntry.Text = ageEntry.Text = "";
        }
    }
}
