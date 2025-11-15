namespace ViewModelApp
{
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();

            BindingContext = new ViewModels.MainViewModel();
        }
    }
}
