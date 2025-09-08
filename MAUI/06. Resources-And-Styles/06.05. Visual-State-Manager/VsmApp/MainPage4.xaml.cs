using System.Text.RegularExpressions;

namespace VsmApp
{
    public partial class MainPage4 : ContentPage
    {
        public MainPage4()
        {
            InitializeComponent();

            SetState(false);    // initial invalid state
        }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            // validation with regex:
            bool isValid = Regex.IsMatch(e.NewTextValue, @"^\+[1-9]-\d{3}-\d{3}-\d{4}$");
           
            SetState(isValid);
        }

        // set state:
        void SetState(bool isValid)
        {
            string visualState = isValid ? "Valid" : "Invalid";
            VisualStateManager.GoToState(myEntry, visualState);
        }
    }
}
