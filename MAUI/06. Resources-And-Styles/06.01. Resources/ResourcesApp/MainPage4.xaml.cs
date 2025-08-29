namespace ResourcesApp
{
    public partial class MainPage4 : ContentPage
    {
        public MainPage4()
        {
            InitializeComponent();
        }

        private void ColorChange(object sender, EventArgs e)
        {
            Color textColor = (Color)Resources["textColor"];

            Resources["textColor"] = textColor.ToHex() == "#1976D2" 
                ? Color.FromArgb("#00838F") 
                : Color.FromArgb("#1976D2");
        }
    }
}
