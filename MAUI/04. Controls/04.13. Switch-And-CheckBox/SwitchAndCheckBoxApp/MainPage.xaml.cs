namespace SwitchAndCheckBoxApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            label.Text = $"Value: {e.Value}";
        }
    }
}
