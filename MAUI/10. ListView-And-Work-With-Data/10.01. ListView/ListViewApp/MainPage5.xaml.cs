namespace ListViewApp
{
    public partial class MainPage5 : ContentPage
    {
        // ItemTapped example:
        public MainPage5()
        {
            InitializeComponent();

            usersList.ItemsSource = new List<string> { "Tom", "Bob", "Sam", "Alice" };
        }

        private void usersList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selected.Text = $"Clicked: {e.Item}";
        }
    }
}
