namespace DataTransferApp;

public partial class PersonPage : ContentPage
{
    bool edited = true; // edit flag

    // Person to add or edit:
    Person Person { get; set; }

    public PersonPage(Person? person)
    {
        InitializeComponent();

        if (person is null)
        {
            Person = new Person();
            edited = false;
        }
        else
        {
            Person = person;
        }

        BindingContext = Person;
    }

    async void SavePerson(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        // if add:
        if (edited == false)
        {
            if (Application.Current?.MainPage is NavigationPage navPage)
            {
                // navigation stack:
                IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
                
                // page count in the stack:
                int pageCount = navPage.Navigation.NavigationStack.Count;
                
                // get MainPage:
                if (navStack[pageCount - 1] is MainPage mainPage)
                {
                    // call AddPerson method in MainPage:
                    mainPage.AddPerson(Person);
                }
            }
        }
    }
}