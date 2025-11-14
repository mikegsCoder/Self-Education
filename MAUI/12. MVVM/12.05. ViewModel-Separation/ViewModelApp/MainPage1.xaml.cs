namespace ViewModelApp
{
    public partial class MainPage1 : ContentPage
    {
        public MainPage1()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}
