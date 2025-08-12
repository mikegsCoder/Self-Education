using Microsoft.Extensions.Logging.Abstractions;

namespace TableViewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTextCompleted(object sender, EventArgs e)
        {
            loginLbl.Text = loginEntry.Text;
        }

        private void OnStatusChanged(object sender, ToggledEventArgs e)
        {
            saveLbl.Text = saveSwitch.On ? "saved" : "not saved";
        }
    }
}
