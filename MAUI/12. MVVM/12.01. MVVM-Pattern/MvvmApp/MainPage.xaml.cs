namespace MvvmApp
{
    public partial class MainPage : ContentPage
    {
        // Simple MVVM pattern example:
        public MainPage()
        {
            InitializeComponent();

            // ViewModel binding:
            BindingContext = new PersonViewModel();
        }
    }
}
