namespace RadioButtonApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLanguageCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedRadioButton = ((RadioButton)sender);

            if (header != null)
            {
                header.Text = $"Your choice is: {selectedRadioButton.Value}";
            }
        }
    }
}
