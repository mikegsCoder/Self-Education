using System.Collections.ObjectModel;

namespace DataTransferApp
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Person> People { get; set; }

        public MainPage()
        {
            InitializeComponent();

            People = new ObservableCollection<Person>
            {
                new Person {Name="Tom", Age = 38},
                new Person {Name="Bob", Age = 42},
                new Person {Name="Sam", Age = 25},
            };

            peopleList.BindingContext = People;
        }

        // item selection handler:
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // get selected item:
            if (args.SelectedItem is Person selectedPerson)
            {
                // null selected item:
                peopleList.SelectedItem = null;

                // go to person edition page: 
                await Navigation.PushAsync(new PersonPage(selectedPerson));
            }
        }

        // Go to PersonPage to add new item:
        async void AddButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PersonPage(null));
        }

        // additional method to add item:
        protected internal void AddPerson(Person person)
        {
            People.Add(person);
        }
    }
}
