using System.Collections.ObjectModel;

namespace GroupingApp
{
    public partial class MainPage2 : ContentPage
    {
        // Grouping collection:
        public ObservableCollection<Grouping<string, User>> UserGroups { get; set; }

        public MainPage2()
        {
            InitializeComponent();

            // initial data:
            var users = new List<User>
            {
                new User {Name="Tom", Company="Microsoft" },
                new User {Name="Sam", Company="Google" },
                new User {Name="Alice", Company="Microsoft" },
                new User {Name="Bob", Company="JetBrains" },
                new User {Name="Kate", Company="Google" },
            };

            // set groups:
            var groups = users.GroupBy(p => p.Company).Select(g => new Grouping<string, User>(g.Key, g));

            // set UserGroups:
            UserGroups = new ObservableCollection<Grouping<string, User>>(groups);

            BindingContext = this;
        }
    }
}
