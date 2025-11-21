namespace CarouselViewApp
{
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private void carouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            Product? current = e.CurrentItem as Product;
            Product? previous = e.PreviousItem as Product;

            header.Text = $"Current: {current?.Name}  Previous: {previous?.Name}";
        }
    }
}
