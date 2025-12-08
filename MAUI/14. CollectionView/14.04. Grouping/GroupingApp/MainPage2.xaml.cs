using System.Collections.ObjectModel;

namespace GroupingApp
{
    public partial class MainPage2 : ContentPage
    {
        // ObservableCollection for binding:
        public ObservableCollection<Grouping<string, Person>> PeopleGroups { get; set; }
       
        public MainPage2()
        {
            InitializeComponent();

            // initial data:
            var people = new List<Person>
            {
                    new Person {Name="Tom", Company="Microsoft" },
                    new Person {Name="Sam", Company="Google" },
                    new Person {Name="Alice", Company="Microsoft" },
                    new Person {Name="Bob", Company="JetBrains" },
                    new Person {Name="Kate", Company="Google" },
            };

            // set groups:
            var groups = people.GroupBy(p => p.Company).Select(g => new Grouping<string, Person>(g.Key, g));
            
            // set PeopleGroups
            PeopleGroups = new ObservableCollection<Grouping<string, Person>>(groups);
            
            BindingContext = this;
        }
    }
}
