namespace DateAndTimePickerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DateSelected(object sender, DateChangedEventArgs e)
        {
            if (label is { })
                label.Text = $"Your choice is: {e.NewDate.ToString("d")}";
        }
    }
}
