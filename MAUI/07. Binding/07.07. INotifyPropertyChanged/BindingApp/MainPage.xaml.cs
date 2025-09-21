namespace BindingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void UpdateAge(object sender, EventArgs e)
        {
            var person = Resources["person"] as Person;

            person.Age++;
        }
    }
}
