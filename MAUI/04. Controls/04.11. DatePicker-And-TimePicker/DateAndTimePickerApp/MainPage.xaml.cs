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

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                label.Text = $"Your choice is: {timePicker.Time}";
            }
        }
    }
}
