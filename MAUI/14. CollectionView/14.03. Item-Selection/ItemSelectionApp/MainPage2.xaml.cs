namespace ItemSelectionApp
{
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string labelText = "";

            if (e.CurrentSelection.FirstOrDefault() is Person current)
            {
                labelText = $"Current: {current.Name}";
            }

            if (e.PreviousSelection.FirstOrDefault() is Person previous)
            {
                labelText = $"{labelText}\nPrevious: {previous.Name}";
            }
            
            selectedLabel.Text = labelText;
        }
    }
}
