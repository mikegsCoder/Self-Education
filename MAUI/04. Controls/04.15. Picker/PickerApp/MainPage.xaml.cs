namespace PickerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = $"Your choice is: {languagePicker.SelectedItem}";
        }
    }
}
