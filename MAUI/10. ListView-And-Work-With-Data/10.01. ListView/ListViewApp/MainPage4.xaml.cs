namespace ListViewApp
{
    public partial class MainPage4 : ContentPage
    {
        // ItemSelected example:
        public MainPage4()
        {
            InitializeComponent();

            usersList.ItemsSource = new List<string> { "Tom", "Bob", "Sam", "Alice" };
        }

        private void usersList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            selected.Text = $"Chosen: {e.SelectedItem}";
        }
    }
}
