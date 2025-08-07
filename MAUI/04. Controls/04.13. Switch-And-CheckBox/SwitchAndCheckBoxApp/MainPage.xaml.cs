namespace SwitchAndCheckBoxApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void Switcher_Toggled(object sender, ToggledEventArgs e)
        //{
        //    label.Text = $"Value: {e.Value}";
        //}

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            statusLabel.Text = $"Status: {(e.Value ? "On" : "Off")}";
        }
    }
}
