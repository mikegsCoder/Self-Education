namespace StepperAndSliderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            header.Text = $"Your choice is: {e.NewValue:F1}";
        }
    }
}
